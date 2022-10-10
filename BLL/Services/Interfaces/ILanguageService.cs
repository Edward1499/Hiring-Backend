using BLL.DTOs.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ILanguageService
    {
        IEnumerable<ResponseLanguageDTO> GetAll();
        IEnumerable<ResponseLanguageDTO> GetAllActive();
        ResponseLanguageDTO GetById(int id);
        ResponseLanguageDTO Add(CreateLanguageDTO createLanguageDTO);
        ResponseLanguageDTO Update(CreateLanguageDTO createLanguageDTO, int id);
        ResponseLanguageDTO Delete(int id);
    }
}
