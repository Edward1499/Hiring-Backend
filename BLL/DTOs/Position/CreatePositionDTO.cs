using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Position
{
    public class CreatePositionDTO
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RiskLevel { get; set; }
        public double MinSalary { get; set; }
        public double MaxSalary { get; set; }
        public bool IsActive { get; set; }
        public List<CreatePositionSkillDTO> Skills { get; set; }
    }
}
