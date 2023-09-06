using System.ComponentModel.DataAnnotations;

namespace DoBemSolution.Models
{
    public class Turma
    {

        [Key]
        public int IdTurma { get; set; }

        [Required]
        public DateTime Inicio { get; set; }

        [Required]
        public DateTime Encerramento { get; set; }

         
    }
    
}
