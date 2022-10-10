using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CandidateLanguage : BaseEntity
    {
        public int CandidateId { get; set; }
        public int LanguageId { get; set; }
        public int Level { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Language Language { get; set; }
    }
}
