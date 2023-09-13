using System.ComponentModel.DataAnnotations;

namespace DoBemSolution.Models
{
    public class Curso
    {

        [Key]
        public int IdCurso { get; set; }

        [Required]
        public string NomeCurso { get; set; }
        
        [Required]
        public string CargaHorariaCurso { get; set; }
    }
}
