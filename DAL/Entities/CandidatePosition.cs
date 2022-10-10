using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CandidatePosition : BaseEntity
    {
        public int CandidateId { get; set; }
        public int PositionId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Position Position { get; set; }
    }
}
