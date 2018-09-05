using Estudiantes.Domain.Entity;
using Estudiantes.Application.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace RestAPI.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() => CreateMap<Estudiante, EstudianteDTO>().ReverseMap();
    }
}