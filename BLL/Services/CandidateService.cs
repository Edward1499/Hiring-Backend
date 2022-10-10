using AutoMapper;
using BLL.DTOs.Candidate;
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
    public class CandidateService : ICandidateService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ICandidateRepository candidateRepository;
        private readonly ICandidateCompetionRepository candidateCompetionRepository;
        private readonly ICandidateLanguageRepository candidateLanguageRepository;
        private readonly ICandidateExpirienceRepository candidateExpirienceRepository;
        private readonly ICandidateTrainingRepository candidateTrainingRepository;
        private readonly ICandidatePositionRepository candidatePositionRepository;
        private readonly IMapper mapper;

        public CandidateService(
            ApplicationDbContext dbContext,
            ICandidateRepository candidateRepository,
            ICandidateCompetionRepository candidateCompetionRepository,
            ICandidateLanguageRepository candidateLanguageRepository,
            ICandidateExpirienceRepository candidateExpirienceRepository,
            ICandidateTrainingRepository candidateTrainingRepository,
            ICandidatePositionRepository candidatePositionRepository,
            IMapper mapper
        )
        {
            this.dbContext = dbContext;
            this.candidateRepository = candidateRepository;
            this.candidateCompetionRepository = candidateCompetionRepository;
            this.candidateLanguageRepository = candidateLanguageRepository;
            this.candidateExpirienceRepository = candidateExpirienceRepository;
            this.candidateTrainingRepository = candidateTrainingRepository;
            this.candidatePositionRepository = candidatePositionRepository;
            this.mapper = mapper;
        }

        public CandidateResponseDTO GetById(int id)
        {
            return mapper.Map<CandidateResponseDTO>(candidateRepository.GetById(id));
        }

        public CandidateResponseDTO GetByUserId(string userId)
        {
            return mapper.Map<CandidateResponseDTO>(candidateRepository.SingleOrDefault(x => x.UserId == userId));
        }

        public IEnumerable<CandidateResponseDTO> GetAllByPositionId(int positionId)
        {
            var candidatesPosition = candidatePositionRepository.Find(x => x.PositionId == positionId).ToList();
            var candidateList = new List<CandidateResponseDTO>();

            candidatesPosition.ForEach(x =>
            {
                candidateList.Add(mapper.Map<CandidateResponseDTO>(candidateRepository.GetById(x.CandidateId)));
            });

            return candidateList;
        }

        public CandidateResponseDTO Add(CreateCandidateDTO createCandidateDTO)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            var newCandidate = candidateRepository.Add(mapper.Map<Candidate>(createCandidateDTO));

            transaction.Commit();

            return mapper.Map<CandidateResponseDTO>(newCandidate);
        }

        public CandidateResponseDTO Update(CreateCandidateDTO createCandidateDTO, int id)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            candidateCompetionRepository.RemoveRange(candidateCompetionRepository.Find(x => x.CandidateId == id).ToList());
            candidateLanguageRepository.RemoveRange(candidateLanguageRepository.Find(x => x.CandidateId == id).ToList());
            candidateExpirienceRepository.RemoveRange(candidateExpirienceRepository.Find(x => x.CandidateId == id).ToList());
            candidateTrainingRepository.RemoveRange(candidateTrainingRepository.Find(x => x.CandidateId == id).ToList());

            var candidate = candidateRepository.GetById(id);

            candidate = mapper.Map<Candidate>(createCandidateDTO);
            candidate.Id = id;
            candidate.Competitions.ForEach(x => x.CandidateId = id);
            candidate.Languages.ForEach(x => x.CandidateId = id);
            candidate.Expiriences.ForEach(x => x.CandidateId = id);
            candidate.Trainings.ForEach(x => x.CandidateId = id);

            candidateRepository.Update(candidate);

            transaction.Commit();

            return mapper.Map<CandidateResponseDTO>(candidate);
        }
    }
}
