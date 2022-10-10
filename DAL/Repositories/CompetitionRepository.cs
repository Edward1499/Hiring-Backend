using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CompetitionRepository : BaseRepositoryDAO<Competition>, ICompetitionRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CompetitionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public new Competition GetById(int id)
        {               
            return dbContext.Competitions
                .Where(c => c.Id == id)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}
