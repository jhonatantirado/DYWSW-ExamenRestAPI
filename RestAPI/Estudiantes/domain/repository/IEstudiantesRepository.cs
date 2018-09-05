using System.Collections.Generic;
using Estudiantes.Domain.Entity;
namespace Estudiantes.Domain.Repository{
    public interface IEstudiantesRepository
    {
        Estudiante findByStudentCode (string studentCode);
        List<Estudiante> findByStudentType (string studentType);
        List<Estudiante> getAll();
    }
}