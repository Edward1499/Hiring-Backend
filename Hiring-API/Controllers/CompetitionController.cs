using BLL.DTOs.Competition;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly ICompetitionService competitionService;

        public CompetitionController(ICompetitionService competitionService)
        {
            this.competitionService = competitionService;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(competitionService.GetAll());
        }

        [HttpGet("GetAllActive")]
        public ActionResult GetAllActive()
        {
            return Ok(competitionService.GetAllActive());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(competitionService.GetById(id));
        }

        [HttpPost]
        public ActionResult Create(CreateCompetitionDTO request)
        {
            return Ok(competitionService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreateCompetitionDTO request, int id)
        {
            return Ok(competitionService.Update(request, id));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(competitionService.Delete(id));
        }
    }
}
