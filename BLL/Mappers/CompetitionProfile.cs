using AutoMapper;
using BLL.DTOs.Competition;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class CompetitionProfile : Profile
    {
        public CompetitionProfile()
        {
            CreateMap<Competition, CreateCompetitionDTO>().ReverseMap();
            CreateMap<Competition, ResponseCompetitionDTO>().ReverseMap();
        }
    }
}
