using AutoMapper;
using BLL.DTOs.Language;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, CreateLanguageDTO>().ReverseMap();
            CreateMap<Language, ResponseLanguageDTO>().ReverseMap();
        }
    }
}
