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
    public class LanguageRepository : BaseRepositoryDAO<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext dbContext;

        public LanguageRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public new Language GetById(int id)
        {
            return dbContext.Languages
                .Where(c => c.Id == id)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}
