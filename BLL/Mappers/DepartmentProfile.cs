using AutoMapper;
using BLL.DTOs.Department;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<ResponseDepartmentDTO, Department>().ReverseMap();
            CreateMap<CreateDepartmentDTO, Department>().ReverseMap();
        }
    }
}
