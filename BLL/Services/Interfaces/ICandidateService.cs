using BLL.DTOs.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ICandidateService
    {
        CandidateResponseDTO GetById(int id);
        CandidateResponseDTO GetByUserId(string userId);
        IEnumerable<CandidateResponseDTO> GetAllByPositionId(int positionId);
        CandidateResponseDTO Add(CreateCandidateDTO createCandidateDTO);
        CandidateResponseDTO Update(CreateCandidateDTO createCandidateDTO, int id);
    }
}
