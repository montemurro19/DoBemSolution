using System.ComponentModel.DataAnnotations;

namespace DoBemSolution.Models
{
    public class Curso
    {
        [Required]
        public string Nome { get; set; }
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string CargaHoraria { get; set; }
    }
}
