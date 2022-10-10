using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Candidate
{
    public class CreateCandidateExpirienceDTO
    {
        public string Company { get; set; }
        public string CurrentPosition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Salary { get; set; }
    }
}
