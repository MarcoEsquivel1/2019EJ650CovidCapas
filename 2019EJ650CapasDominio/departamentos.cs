using _2019EJ650CapasContexto;
using _2019EJ650CapasEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019EJ650CapasDominio
{
    public class departamentos
    {
        private readonly dbContext _contexto;
        public departamentos(dbContext miContexto)
        {
            this._contexto = miContexto;
        }
        public IEnumerable<Departamentos> listado() {
            IEnumerable<Departamentos> listaDepartamentos = from d in _contexto.departamentos select d;

            return listaDepartamentos.ToList();
        }
    }
}
