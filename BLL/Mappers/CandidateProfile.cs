using AutoMapper;
using BLL.DTOs.Candidate;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            CreateMap<Candidate, CreateCandidateDTO>().ReverseMap();
            CreateMap<CreateCandidateCompetitionDTO, CandidateCompetition>().ReverseMap();
            CreateMap<CreateCandidateLanguageDTO, CandidateLanguage>().ReverseMap();
            CreateMap<CandidateResponseDTO, Candidate>().ReverseMap();
            CreateMap<CreateCandidateExpirienceDTO, CandidateExpirience>().ReverseMap();
            CreateMap<CreateCandidateTrainingDTO, CandidateTraining>().ReverseMap();
        }
    }
}
