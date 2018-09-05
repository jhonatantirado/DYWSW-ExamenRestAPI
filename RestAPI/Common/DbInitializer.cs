
using Estudiantes.Domain.Entity;
using System.Linq;
using Common.Infrastructure.Repository;

namespace Common
{
    public class DbInitializer
    {
        private readonly PracticaExamenContext _context;

        public DbInitializer(PracticaExamenContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

            if (_context.Estudiantes.Any())
            {
                return;
            }

            int n = 100;
            for (int i =1; i <= n; i++)
            {
                var estudiantePregrado = new EstudiantePregrado 
                { FirstName = "Jose " + i, LastName = "Quispe "+ i, 
                StudentCode = "Code" + i, StudentType = StudentType.Pregrado,
                IsActive = true};
                _context.Estudiantes.Add(estudiantePregrado);
            }

            n = n + 100;
            for (int i =101; i <= n; i++)
            {
                var estudianteMaestria = new EstudianteMaestria 
                { FirstName = "Pedro " + i, LastName = "Flores "+ i, 
                StudentCode = "Code" + i, StudentType = StudentType.Maestria,
                IsActive = true};
                _context.Estudiantes.Add(estudianteMaestria);
            }

            n = n + 100;
            for (int i =201; i <= n; i++)
            {
                var estudianteDoctorado = new EstudianteDoctorado 
                { FirstName = "Jose " + i, LastName = "Lopez "+ i, 
                StudentCode = "Code" + i, StudentType = StudentType.Doctorado,
                IsActive = true};
                _context.Estudiantes.Add(estudianteDoctorado);
            }
            _context.SaveChanges();

        }
    }
}
