using BLL.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        ResponseEmployeeDTO Hire(HireEmployeeDTO hireEmployeeDTO);
        IEnumerable<ResponseEmployeeDTO> GetAll();
        IEnumerable<ResponseEmployeeDTO> GetAll(GetAllEmployeeDTO dates);
    }
}
