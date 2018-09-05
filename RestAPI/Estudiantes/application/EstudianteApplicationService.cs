namespace Estudiantes.Application
{

    using AutoMapper;
    using Common.Infrastructure.Repository;
    using System;
    using Estudiantes.Domain.Entity;
    using Common.Application;
    using Estudiantes.Application.Dto;
    using Estudiantes.Domain.Service;
    using Common.Application.Dto;
    using System.Linq;
    using System.Collections.Generic;

    public class EstudianteApplicationService : IEstudianteApplicationService
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IMapper _mapper;
        private readonly EstudianteDomainService estudianteDomainService;

        public EstudianteApplicationService(IUnitOfWork iUnitOfWork, IMapper mapper)
        {
            estudianteDomainService = new EstudianteDomainService();
            _iUnitOfWork = iUnitOfWork;
            _mapper = mapper;
        }

        public decimal calculateScholarship(string studentCode){
            var estudiante = _iUnitOfWork.Estudiantes.findByStudentCode(studentCode);
            return estudianteDomainService.calculateScholarship(estudiante);
        }
        public List<EstudianteDTO> getByStudentType(string studentType){
            var estudiantes = _iUnitOfWork.Estudiantes.findByStudentType(studentType);
            List<EstudianteDTO> estudiantesDto = _mapper.Map<List<EstudianteDTO>>(estudiantes);
            return estudiantesDto;
        }
        
        public List<EstudianteDTO> getAll(){
            var estudiantes = _iUnitOfWork.Estudiantes.getAll();
            List<EstudianteDTO> estudiantesDto = _mapper.Map<List<EstudianteDTO>>(estudiantes);
            return estudiantesDto;
        }

    }
}
