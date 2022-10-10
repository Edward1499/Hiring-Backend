using BLL.DTOs.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IPositionService
    {
        IEnumerable<PositionResponseDTO> GetAll();
        IEnumerable<PositionResponseDTO> GetAllActive();
        PositionResponseDTO GetById(int id);
        PositionResponseDTO Add(CreatePositionDTO createPositionDTO);
        PositionResponseDTO Update(CreatePositionDTO createPositionDTO, int id);
        bool HasApplied(ApplyRequestDTO hasAppliedRequestDTO);
        void Apply(ApplyRequestDTO applyRequestDTO);
        PositionResponseDTO Delete(int id);
        PositionResponseDTO Disable(int id);
    }
}
