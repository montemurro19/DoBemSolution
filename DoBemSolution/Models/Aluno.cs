using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoBemSolution.Models
{
    public class Aluno
    {

        [Key]
        public int IdAluno { get; set; }

        [Required]
        public string RegistroAluno { get; set; }

        [ForeignKey("Usuario")]
        public int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

