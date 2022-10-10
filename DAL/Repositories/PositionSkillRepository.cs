using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PositionSkillRepository : BaseRepositoryDAO<PositionSkill>, IPositionSkillRepository
    {
        public PositionSkillRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
