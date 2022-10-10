using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee : BaseEntity
    {
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime StartDate { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
        public double MonthlySalary { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual Department Department { get; set; }
    }
}
