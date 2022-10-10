using BLL.DTOs.AcademicLevel;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicLevelController : ControllerBase
    {
        private readonly IAcademicLevelService academicLevelService;

        public AcademicLevelController(IAcademicLevelService academicLevelService)
        {
            this.academicLevelService = academicLevelService;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(academicLevelService.GetAll());
        }

        [HttpGet("GetAllActive")]
        public ActionResult GetAllActive()
        {
            return Ok(academicLevelService.GetAllActive());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(academicLevelService.GetById(id));
        }

        [HttpPost]
        public ActionResult Create(CreateAcademicLevelDTO request)
        {
            return Ok(academicLevelService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreateAcademicLevelDTO request, int id)
        {
            return Ok(academicLevelService.Update(request, id));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(academicLevelService.Delete(id));
        }
    }
}
