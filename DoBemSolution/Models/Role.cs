namespace DoBemSolution.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        // Relação muitos-para-muitos com a classe Usuario
        public virtual ICollection<Usuario> Usiarios { get; set; }

    }
}
