using Estudiantes.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.Repository
{
    public class PracticaExamenContext : DbContext
    {
        public PracticaExamenContext()
        {
        }

        public PracticaExamenContext(DbContextOptions<PracticaExamenContext> options) : base(options)
        {
        }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudiantePregrado>();
            modelBuilder.Entity<EstudianteMaestria>();
            modelBuilder.Entity<EstudianteDoctorado>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
