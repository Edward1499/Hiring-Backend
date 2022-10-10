using AutoMapper;
using BLL.DTOs.Competition;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CompetitionService : ICompetitionService
    {
        private readonly ICompetitionRepository competitionRepository;
        private readonly IMapper mapper;

        public CompetitionService(
            ICompetitionRepository competitionRepository,
            IMapper mapper
        )
        {
            this.competitionRepository = competitionRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ResponseCompetitionDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ResponseCompetitionDTO>>(competitionRepository.GetAll());
        }

        public IEnumerable<ResponseCompetitionDTO> GetAllActive()
        {
            return mapper.Map<IEnumerable<ResponseCompetitionDTO>>(competitionRepository.Find(x => x.IsActive));
        }

        public ResponseCompetitionDTO GetById(int id)
        {
            return mapper.Map<ResponseCompetitionDTO>(competitionRepository.GetById(id));
        }

        public ResponseCompetitionDTO Add(CreateCompetitionDTO createCompetitionDTO)
        {
            var newCompetition = competitionRepository.Add(mapper.Map<Competition>(createCompetitionDTO));

            return mapper.Map<ResponseCompetitionDTO>(newCompetition);
        }

        public ResponseCompetitionDTO Update(CreateCompetitionDTO createCompetitionDTO, int id)
        {
            var competition = competitionRepository.GetById(id);

            var newCompetition = mapper.Map<Competition>(createCompetitionDTO);
            newCompetition.Id = id;
            newCompetition.CreatedAt = competition.CreatedAt;

            return mapper.Map<ResponseCompetitionDTO>(competitionRepository.Update(newCompetition));
        }

        public ResponseCompetitionDTO Delete(int id)
        {
            var competition = competitionRepository.GetById(id);

            return mapper.Map<ResponseCompetitionDTO>(competitionRepository.Remove(competition));
        }
    }
}
