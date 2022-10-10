using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<AcademicLevel> AcademicLevels { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateCompetition> CandidateCompetitions { get; set; }
        public DbSet<CandidateExpirience> CandidateExpiriences { get; set; }
        public DbSet<CandidateLanguage> CandidateLanguages { get; set; }
        public DbSet<CandidateTraining> CandidateTrainings { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<CandidatePosition> CandidatePositions { get; set; }
        public DbSet<PositionSkill> PositionSkills { get; set; }
    }
}
