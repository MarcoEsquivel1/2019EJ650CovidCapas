using _2019EJ650CapasContexto;
using _2019EJ650CapasEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019EJ650CapasDominio
{
    public class casos
    {
        private readonly dbContext _contexto;
        public casos(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IEnumerable<Casos> listado()
        {
            IEnumerable<Casos> listaCasos = (from c in _contexto.casos
                                        join d in _contexto.departamentos on c.departamentoId equals d.departamentoId
                                        join g in _contexto.generos on c.generoId equals g.generoId
                                        select new Casos
                                        {
                                            departamento = d.departamento,
                                            genero = g.genero,
                                            confirmados = c.confirmados,
                                            recuperados = c.recuperados,
                                            fallecidos = c.fallecidos,
                                        });
            return listaCasos.ToList();
        }
    }
}
