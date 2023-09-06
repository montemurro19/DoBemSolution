namespace DoBemSolution.Models
{
    public class Usuario
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsBlocked { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }

    }
}
