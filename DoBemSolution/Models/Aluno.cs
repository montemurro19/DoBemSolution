using System.ComponentModel.DataAnnotations.Schema;

namespace DoBemSolution.Models
{
    public class Aluno
    {
        public string RegistroAluno { get; set; }

        [ForeignKey("Usuario")]
        public int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

