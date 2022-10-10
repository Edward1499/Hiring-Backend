using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Candidate : BaseEntity
    {
        public string UserId { get; set; }
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public double Salary { get; set; }
        public string RecomendedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual IdentityUser User { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<CandidateCompetition> Competitions { get; set; }
        public virtual List<CandidateLanguage> Languages { get; set; }
        public virtual List<CandidateExpirience> Expiriences { get; set; }
        public virtual List<CandidateTraining> Trainings { get; set; }
    }
}
