using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoBemSolution.Models
{
    public class Feedback
    {
        [Key]
        public int id { set; get; }

        public string nome { set; get; } 

        public string texto { set; get; }

        public int estrelas { set; get; }

        public bool autorizacao { set; get; }
    }
}
