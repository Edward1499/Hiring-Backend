using BLL.DTOs.AcademicLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAcademicLevelService
    {
        IEnumerable<ResponseAcademicLevelDTO> GetAll();
        IEnumerable<ResponseAcademicLevelDTO> GetAllActive();
        ResponseAcademicLevelDTO GetById(int id);
        ResponseAcademicLevelDTO Add(CreateAcademicLevelDTO createAcademicLevelDTO);
        ResponseAcademicLevelDTO Update(CreateAcademicLevelDTO createAcademicLevelDTO, int id);
        ResponseAcademicLevelDTO Delete(int id);
    }
}
