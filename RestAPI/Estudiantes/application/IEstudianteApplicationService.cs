using Estudiantes.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.Application
{

    public interface IEstudianteApplicationService
    {
        decimal calculateScholarship(string studentCode);
        List<EstudianteDTO> getByStudentType(string studentType); 
        List<EstudianteDTO> getAll(); 

    }
}
