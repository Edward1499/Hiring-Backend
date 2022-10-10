using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PositionRepository : BaseRepositoryDAO<Position>, IPositionRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PositionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public new IEnumerable<Position> GetAll()
        {
            return dbContext.Positions
                .Include(x => x.Skills);
        }

        public new Position GetById(int id)
        {
            return dbContext.Positions
                .Where(c => c.Id == id)
                .AsNoTracking()
                .Include(x => x.Skills)
                .Include(x => x.Department)
                .FirstOrDefault();
        }

        public new IEnumerable<Position> Find(Expression<Func<Position, bool>> predicate)
        {
            return dbContext.Positions
                .Where(predicate)
                .Include(x => x.Skills);
        }
    }
}
