using System.ComponentModel.DataAnnotations;

namespace _2019EJ650CapasEntidades
{
    public class Departamentos
    {
        [Key]
        public int departamentoId { get; set; }
        public string departamento { get; set; }
    }
}
