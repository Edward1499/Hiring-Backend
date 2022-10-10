using BLL.DTOs.Language;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService languageService;

        public LanguageController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(languageService.GetAll());
        }

        [HttpGet("GetAllActive")]
        public ActionResult GetAllActive()
        {
            return Ok(languageService.GetAllActive());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(languageService.GetById(id));
        }

        [HttpPost]
        public ActionResult Create(CreateLanguageDTO request)
        {
            return Ok(languageService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreateLanguageDTO request, int id)
        {
            return Ok(languageService.Update(request, id));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(languageService.Delete(id));
        }
    }
}
