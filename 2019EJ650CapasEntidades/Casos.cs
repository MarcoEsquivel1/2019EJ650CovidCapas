using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2019EJ650CapasEntidades
{
    public class Casos
    {
        [Key]
        public int casoId { get; set; }

        [NotMapped]
        public string departamento { get; set; }

        [Required]
        public int departamentoId { get; set; }

        [NotMapped]
        public string genero { get; set; }

        [Required]
        public int generoId { get; set; }

        [Required]
        public int confirmados { get; set; }

        [Required]
        public int recuperados { get; set; }

        [Required]
        public int fallecidos { get; set; }
    }
}
