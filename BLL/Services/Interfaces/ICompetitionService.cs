using BLL.DTOs.Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ICompetitionService
    {
        IEnumerable<ResponseCompetitionDTO> GetAll();
        IEnumerable<ResponseCompetitionDTO> GetAllActive();
        ResponseCompetitionDTO GetById(int id);
        ResponseCompetitionDTO Add(CreateCompetitionDTO createCompetitionDTO);
        ResponseCompetitionDTO Update(CreateCompetitionDTO createCompetitionDTO, int id);
        ResponseCompetitionDTO Delete(int id);
    }
}
