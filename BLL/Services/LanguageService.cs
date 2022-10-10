using AutoMapper;
using BLL.DTOs.Language;
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
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository languageRepository;
        private readonly IMapper mapper;

        public LanguageService(
            ILanguageRepository languageRepository,
            IMapper mapper
        )
        {
            this.languageRepository = languageRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ResponseLanguageDTO> GetAll()
        {
            return mapper.Map<IEnumerable<ResponseLanguageDTO>>(languageRepository.GetAll());
        }

        public IEnumerable<ResponseLanguageDTO> GetAllActive()
        {
            return mapper.Map<IEnumerable<ResponseLanguageDTO>>(languageRepository.Find(x => x.IsActive));
        }

        public ResponseLanguageDTO GetById(int id)
        {
            return mapper.Map<ResponseLanguageDTO>(languageRepository.GetById(id));
        }

        public ResponseLanguageDTO Add(CreateLanguageDTO createLanguageDTO)
        {
            var newLanguage = languageRepository.Add(mapper.Map<Language>(createLanguageDTO));

            return mapper.Map<ResponseLanguageDTO>(newLanguage);
        }

        public ResponseLanguageDTO Update(CreateLanguageDTO createLanguageDTO, int id)
        {
            var language = languageRepository.GetById(id);

            var newLanguage = mapper.Map<Language>(createLanguageDTO);
            newLanguage.Id = id;
            newLanguage.CreatedAt = language.CreatedAt;

            return mapper.Map<ResponseLanguageDTO>(languageRepository.Update(newLanguage));
        }

        public ResponseLanguageDTO Delete(int id)
        {
            var language = languageRepository.GetById(id);

            return mapper.Map<ResponseLanguageDTO>(languageRepository.Remove(language));
        }
    }
}
