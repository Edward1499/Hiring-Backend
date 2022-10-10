using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Candidate
{
    public class CreateCandidateTrainingDTO
    {
        public string Description { get; set; }
        public int AcademicLevelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Institution { get; set; }
    }
}
