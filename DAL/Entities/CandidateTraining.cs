using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CandidateTraining : BaseEntity
    {
        public string Description { get; set; }
        public int AcademicLevelId { get; set; }
        public int CandidateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Institution { get; set; }

        public virtual AcademicLevel AcademicLevel { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
