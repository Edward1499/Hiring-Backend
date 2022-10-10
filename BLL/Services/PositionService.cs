using AutoMapper;
using BLL.DTOs.Position;
using BLL.Services.Interfaces;
using DAL;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PositionService : IPositionService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IPositionRepository positionRepository;
        private readonly IPositionSkillRepository positionSkillRepository;
        private readonly ICandidatePositionRepository candidatePositionRepository;
        private readonly IMapper mapper;

        public PositionService(
            ApplicationDbContext dbContext,
            IPositionRepository positionRepository,
            IPositionSkillRepository positionSkillRepository,
            ICandidatePositionRepository candidatePositionRepository,
            IMapper mapper
        )
        {
            this.dbContext = dbContext;
            this.positionRepository = positionRepository;
            this.positionSkillRepository = positionSkillRepository;
            this.candidatePositionRepository = candidatePositionRepository;
            this.mapper = mapper;
        }

        public IEnumerable<PositionResponseDTO> GetAll()
        {
            return mapper.Map<IEnumerable<PositionResponseDTO>>(positionRepository.GetAll());
        }

        public IEnumerable<PositionResponseDTO> GetAllActive()
        {
            return mapper.Map<IEnumerable<PositionResponseDTO>>(positionRepository.Find(x => x.IsActive));
        }

        public PositionResponseDTO GetById(int id)
        {
            return mapper.Map<PositionResponseDTO>(positionRepository.GetById(id));
        }

        public PositionResponseDTO Add(CreatePositionDTO createPositionDTO)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            var newPosition = positionRepository.Add(mapper.Map<Position>(createPositionDTO));

            transaction.Commit();

            return mapper.Map<PositionResponseDTO>(newPosition);

        }

        public PositionResponseDTO Update(CreatePositionDTO createPositionDTO, int id)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            positionSkillRepository.RemoveRange(positionSkillRepository.Find(x => x.PositionId == id).ToList());

            var position = positionRepository.GetById(id);

            position = mapper.Map<Position>(createPositionDTO);
            position.Id = id;
            position.Skills.ForEach(x => x.PositionId = id);

            positionRepository.Update(position);

            transaction.Commit();

            return mapper.Map<PositionResponseDTO>(position);
        }

        public bool HasApplied(ApplyRequestDTO hasAppliedRequestDTO)
        {
            var candidatePosition = candidatePositionRepository.SingleOrDefault(x => x.PositionId == hasAppliedRequestDTO.PositionId && x.CandidateId == hasAppliedRequestDTO.CandidateId);

            return candidatePosition != null;
        }

        public void Apply(ApplyRequestDTO applyRequestDTO)
        {
            candidatePositionRepository.Add(mapper.Map<CandidatePosition>(applyRequestDTO));
        }

        public PositionResponseDTO Delete(int id)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            var position = positionRepository.GetById(id);

            if (position.Skills.Count > 0) positionSkillRepository.RemoveRange(position.Skills);

            positionRepository.Remove(position);

            transaction.Commit();

            return mapper.Map<PositionResponseDTO>(position);
        }

        public PositionResponseDTO Disable(int id)
        {
            var position = positionRepository.GetById(id);
            position.IsActive = false;

            positionRepository.Update(position);

            return mapper.Map<PositionResponseDTO>(position);
        }
    }
}
