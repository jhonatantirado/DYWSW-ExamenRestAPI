using Estudiantes.Domain.Repository;
namespace Common.Infrastructure.Repository
{
    public class UnitOfWork  : IUnitOfWork
    {
        protected readonly PracticaExamenContext _context;

        public UnitOfWork(PracticaExamenContext dbContext)
        {
            _context = dbContext;
            Estudiantes = new EstudiantesRepository(_context);
        }

        public IEstudiantesRepository Estudiantes { get; private set;}

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
