using AutoMapper;
using BLL.DTOs.Employee;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, HireEmployeeDTO>().ReverseMap();
            CreateMap<Employee, ResponseEmployeeDTO>().ReverseMap();
        }
    }
}
