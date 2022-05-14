using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019EJ650CapasDominio;
using _2019EJ650CapasContexto;
using Microsoft.AspNetCore.Mvc.Rendering;
using _2019EJ650CapasEntidades;

namespace _2019EJ650CapasApp.Controllers
{
    public class covidController : Controller
    {
        private readonly dbContext _contexto;
        public covidController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IActionResult Index()
        {
            ViewBag.ComboDepartamentosValores = comboDepartamentos();
            ViewBag.ComboGenerosValores = comboGeneros();
            var casos = new casos(_contexto).listado();

            return View(casos);
        }

        public List<SelectListItem> comboDepartamentos() {
            var listaDepartamentos = new departamentos(_contexto).listado();
            List<SelectListItem> ComboDepartamentosValores = new List<SelectListItem>();
            foreach (Departamentos departamento in listaDepartamentos)
            {
                SelectListItem miOpcion = new SelectListItem
                {
                    Text = departamento.departamento,
                    Value = departamento.departamentoId.ToString()
                };

                ComboDepartamentosValores.Add(miOpcion);
            }

            return ComboDepartamentosValores;
        }

        public List<SelectListItem> comboGeneros()
        {
            var listaGeneros = new generos(_contexto).listado();
            List<SelectListItem> ComboGenerosValores = new List<SelectListItem>();
            foreach (Generos genero in listaGeneros)
            {
                SelectListItem miOpcion = new SelectListItem
                {
                    Text = genero.genero,
                    Value = genero.generoId.ToString()
                };

                ComboGenerosValores.Add(miOpcion);
            }

            return ComboGenerosValores;
        }

        public IActionResult postNew(Casos datosForm)
        {
            var nuevo = new Casos()
            {
                casoId = datosForm.casoId,
                departamentoId = datosForm.departamentoId,
                generoId = datosForm.generoId,
                confirmados = datosForm.confirmados,
                recuperados = datosForm.recuperados,
                fallecidos = datosForm.fallecidos
            };

            _contexto.casos.Add(nuevo);
            _contexto.SaveChanges();
            return RedirectToAction("Index", "covid");
        }
    }
}
