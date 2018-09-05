using System.Collections.Generic;
using Common.Infrastructure.Repository;
using Estudiantes.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Estudiantes.Domain.Repository{
    public class EstudiantesRepository : BaseRepository<Estudiante>, IEstudiantesRepository
    {
        public EstudiantesRepository(PracticaExamenContext dbContext) : base(dbContext)
        {
        }
        
        public Estudiante findByStudentCode(string studentCode) => base.Context.Set<Estudiante>().Where(x => x.StudentCode == studentCode && x.IsActive).FirstOrDefault();
        public List<Estudiante> getAll() => base.Context.Set<Estudiante>().Where(x => x.IsActive).OrderBy(x=> x.LastName).ThenBy(x=>x.FirstName).ToList();
        public List<Estudiante> findByStudentType(string studentType) {
            return base.Context.Set<Estudiante>().
            Where(x => x.StudentType == studentType && x.IsActive).
            OrderBy(x=> x.LastName).ThenBy(x=>x.FirstName).ToList();
        } 
    }
}