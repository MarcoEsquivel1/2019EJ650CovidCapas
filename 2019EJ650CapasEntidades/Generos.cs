using System.ComponentModel.DataAnnotations;

namespace _2019EJ650CapasEntidades
{
    public class Generos
    {
        [Key]
        public int generoId { get; set; }
        public string genero { get; set; }
    }
}
