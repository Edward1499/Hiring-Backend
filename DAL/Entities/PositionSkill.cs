using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PositionSkill : BaseEntity
    {
        public int PositionId { get; set; }
        public string Description { get; set; }

        public virtual Position Position { get; set; }
    }
}
