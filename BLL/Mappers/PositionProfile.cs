using AutoMapper;
using BLL.DTOs.Position;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, CreatePositionDTO>().ReverseMap();
            CreateMap<PositionSkill, CreatePositionSkillDTO>().ReverseMap();
            CreateMap<Position, PositionResponseDTO>().ReverseMap();
            CreateMap<CandidatePosition, ApplyRequestDTO>().ReverseMap();
        }
    }
}
