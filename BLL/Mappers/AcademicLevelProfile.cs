using AutoMapper;
using BLL.DTOs.AcademicLevel;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class AcademicLevelProfile : Profile
    {
        public AcademicLevelProfile()
        {
            CreateMap<AcademicLevel, CreateAcademicLevelDTO>().ReverseMap();
            CreateMap<AcademicLevel, ResponseAcademicLevelDTO>().ReverseMap();
        }
    }
}
