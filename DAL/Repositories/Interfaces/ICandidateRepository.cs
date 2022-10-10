﻿using DAL.Entities;
using DAL.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ICandidateRepository : IBaseRepositoryDAO<Candidate>
    {
    }
}
