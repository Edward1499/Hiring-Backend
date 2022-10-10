using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CandidateCompetition : BaseEntity
    {
        public int CompetitionId { get; set; }
        public int CandidateId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
