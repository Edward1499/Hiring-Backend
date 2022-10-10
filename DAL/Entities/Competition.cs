using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Competition: BaseEntity
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
