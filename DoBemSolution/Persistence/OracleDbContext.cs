using DoBemSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace DoBemSolution.Persistence
{
    public class OracleDbContext : DbContext 
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Turma> Turma { get; set; }

        public OracleDbContext(DbContextOptions options) : base(options) { }
    }
}
