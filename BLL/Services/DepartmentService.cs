using AutoMapper;
using BLL.DTOs.Department;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepartmentService(
            IDepartmentRepository departmentRepository,
            IMapper mapper
        )
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ResponseDepartmentDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ResponseDepartmentDTO>>(departmentRepository.GetAll());
        }

        public IEnumerable<ResponseDepartmentDTO> GetAllActive()
        {
            return mapper.Map<IEnumerable<ResponseDepartmentDTO>>(departmentRepository.Find(x => x.IsActive));
        }

        public ResponseDepartmentDTO GetById(int id)
        {
            return mapper.Map<ResponseDepartmentDTO>(departmentRepository.GetById(id));
        }

        public ResponseDepartmentDTO Add(CreateDepartmentDTO createDepartmentDTO)
        {
            var newDepartment = departmentRepository.Add(mapper.Map<Department>(createDepartmentDTO));

            return mapper.Map<ResponseDepartmentDTO>(newDepartment);
        }

        public ResponseDepartmentDTO Update(CreateDepartmentDTO createDepartmentDTO, int id)
        {
            var department = departmentRepository.GetById(id);

            var newDepartment = mapper.Map<Department>(createDepartmentDTO);
            newDepartment.Id = id;
            newDepartment.CreatedAt = department.CreatedAt;

            return mapper.Map<ResponseDepartmentDTO>(departmentRepository.Update(newDepartment));
        }

        public ResponseDepartmentDTO Delete(int id)
        {
            var competition = departmentRepository.GetById(id);

            return mapper.Map<ResponseDepartmentDTO>(departmentRepository.Remove(competition));
        }
    }
}
