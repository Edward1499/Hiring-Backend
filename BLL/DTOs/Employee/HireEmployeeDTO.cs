using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Employee
{
    public class HireEmployeeDTO
    {
        public int CandidateId { get; set; }
        public int PositionId { get; set; }
        public DateTime StartDate { get; set; }
        public string Position { get; set; }
        public double MonthlySalary { get; set; }
    }
}
