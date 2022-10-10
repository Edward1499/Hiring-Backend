using AutoMapper;
using BLL.DTOs.AcademicLevel;
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
    public class AcademicLevelService : IAcademicLevelService
    {
        private readonly IAcademicLevelRepository academicLevelRepository;
        private readonly IMapper mapper;

        public AcademicLevelService(
            IAcademicLevelRepository academicLevelRepository,
            IMapper mapper
        )
        {
            this.academicLevelRepository = academicLevelRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ResponseAcademicLevelDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ResponseAcademicLevelDTO>>(academicLevelRepository.GetAll());
        }

        public IEnumerable<ResponseAcademicLevelDTO> GetAllActive()
        {
            return mapper.Map<IEnumerable<ResponseAcademicLevelDTO>>(academicLevelRepository.Find(x => x.IsActive));
        }

        public ResponseAcademicLevelDTO GetById(int id)
        {
            return mapper.Map<ResponseAcademicLevelDTO>(academicLevelRepository.GetById(id));
        }

        public ResponseAcademicLevelDTO Add(CreateAcademicLevelDTO createAcademicLevelDTO)
        {
            var newAcademicLevel = academicLevelRepository.Add(mapper.Map<AcademicLevel>(createAcademicLevelDTO));

            return mapper.Map<ResponseAcademicLevelDTO>(newAcademicLevel);
        }

        public ResponseAcademicLevelDTO Update(CreateAcademicLevelDTO createAcademicLevelDTO, int id)
        {
            var academicLevel = academicLevelRepository.GetById(id);

            var newAcademicLevel = mapper.Map<AcademicLevel>(createAcademicLevelDTO);
            newAcademicLevel.Id = id;
            newAcademicLevel.CreatedAt = academicLevel.CreatedAt;

            return mapper.Map<ResponseAcademicLevelDTO>(academicLevelRepository.Update(newAcademicLevel));
        }

        public ResponseAcademicLevelDTO Delete(int id)
        {
            var academicLevel = academicLevelRepository.GetById(id);

            return mapper.Map<ResponseAcademicLevelDTO>(academicLevelRepository.Remove(academicLevel));
        }
    }
}
