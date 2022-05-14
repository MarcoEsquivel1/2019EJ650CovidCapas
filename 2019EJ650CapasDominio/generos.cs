using _2019EJ650CapasContexto;
using _2019EJ650CapasEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019EJ650CapasDominio
{
    public class generos
    {
        private readonly dbContext _contexto;
        public generos(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IEnumerable<Generos> listado()
        {
            IEnumerable<Generos> listaGeneros = from g in _contexto.generos select g;

            return listaGeneros.ToList();
        }
    }
}
