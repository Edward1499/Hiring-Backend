using BLL.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<ResponseDepartmentDTO> GetAll();
        IEnumerable<ResponseDepartmentDTO> GetAllActive();
        ResponseDepartmentDTO GetById(int id);
        ResponseDepartmentDTO Add(CreateDepartmentDTO createDepartmentDTO);
        ResponseDepartmentDTO Update(CreateDepartmentDTO createDepartmentDTO, int id);
        ResponseDepartmentDTO Delete(int id);
    }
}
