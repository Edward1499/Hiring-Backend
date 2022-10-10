using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AcademicLevel : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
