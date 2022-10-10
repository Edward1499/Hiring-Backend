﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Candidate
{
    public class CandidateResponseDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public double Salary { get; set; }
        public string RecomendedBy { get; set; }
        public bool IsActive { get; set; }
        public virtual List<CreateCandidateCompetitionDTO> Competitions { get; set; }
        public virtual List<CreateCandidateLanguageDTO> Languages { get; set; }
        public List<CreateCandidateExpirienceDTO> Expiriences { get; set; }
        public List<CreateCandidateTrainingDTO> Trainings { get; set; }
    }
}
