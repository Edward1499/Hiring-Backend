using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CandidateExpirience : BaseEntity
    {
        public int CandidateId { get; set; }
        public string Company { get; set; }
        public string CurrentPosition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Salary { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
