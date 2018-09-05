using System;
using Estudiantes.Domain.Repository;

namespace Common.Infrastructure.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        IEstudiantesRepository Estudiantes { get;}
        
    }
}
