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
    public class CandidateRepository : BaseRepositoryDAO<Candidate>, ICandidateRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CandidateRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public new Candidate GetById(int id)
        {
            return dbContext.Candidates
                .Where(c => c.Id == id)
                .AsNoTracking()
                .Include(x => x.Competitions)
                .Include(x => x.Languages)
                .Include(x => x.Expiriences)
                .Include(x => x.Trainings)
                .FirstOrDefault();
        }

        public new Candidate SingleOrDefault(Expression<Func<Candidate, bool>> predicate)
        {
            return dbContext.Candidates
                .Where(predicate)
                .Include(x => x.Competitions)
                .Include(x => x.Languages)
                .Include(x => x.Expiriences)
                .Include(x => x.Trainings)
                .SingleOrDefault();
        }
    }
}
