using AutoMapper;
using BLL.DTOs.Employee;
using BLL.Services.Interfaces;
using DAL;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IEmployeeRepository employeeRepository;
        private readonly ICandidateRepository candidateRepository;
        private readonly IPositionRepository positionRepository;
        private readonly IMapper mapper;

        public EmployeeService(
            ApplicationDbContext dbContext,
            IEmployeeRepository employeeRepository,
            ICandidateRepository candidateRepository,
            IPositionRepository positionRepository,
            IMapper mapper
        )
        {
            this.dbContext = dbContext;
            this.employeeRepository = employeeRepository;
            this.candidateRepository = candidateRepository;
            this.positionRepository = positionRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ResponseEmployeeDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ResponseEmployeeDTO>>(employeeRepository.GetAll());
        }

        public IEnumerable<ResponseEmployeeDTO> GetAll(GetAllEmployeeDTO dates)
        { 
            return mapper.Map<IEnumerable<ResponseEmployeeDTO>>(employeeRepository.Find(x => x.StartDate >= dates.StartDate && x.StartDate <= dates.EndDate));
        }

        public ResponseEmployeeDTO Hire(HireEmployeeDTO hireEmployeeDTO)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            var candidate = candidateRepository.GetById(hireEmployeeDTO.CandidateId);
            var position = positionRepository.GetById(hireEmployeeDTO.PositionId);

            var newEmployee = mapper.Map<Employee>(hireEmployeeDTO);
            newEmployee.PersonalId = candidate.PersonalId;
            newEmployee.Name = candidate.Name;
            newEmployee.Surname = candidate.Surname;
            newEmployee.StartDate = hireEmployeeDTO.StartDate;
            newEmployee.DepartmentId = position.DepartmentId;

            //candidate.IsActive = false;
            //candidateRepository.Update(candidate);

            position.IsActive = false;
            positionRepository.Update(position);

            employeeRepository.Add(newEmployee);

            transaction.Commit();

            return mapper.Map<ResponseEmployeeDTO>(newEmployee);
        }
    }
}
