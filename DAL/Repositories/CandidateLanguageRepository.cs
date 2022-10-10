using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CandidateLanguageRepository : BaseRepositoryDAO<CandidateLanguage>, ICandidateLanguageRepository
    {
        public CandidateLanguageRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
