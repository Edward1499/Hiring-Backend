using BLL.DTOs.Position;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService positionService;

        public PositionController(IPositionService positionService)
        {
            this.positionService = positionService;
        }

        [HttpGet("GetAlL")]
        public ActionResult GetAlL()
        {
            return Ok(positionService.GetAll());
        }

        [HttpGet("GetAllActive")]
        public ActionResult GetAlLActive()
        {
            return Ok(positionService.GetAllActive());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(positionService.GetById(id));
        }

        [HttpGet("Disable/{id}")]
        public ActionResult Disable(int id)
        {
            return Ok(positionService.Disable(id));
        }

        [HttpPost]
        public ActionResult Create(CreatePositionDTO request)
        {
            return Ok(positionService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreatePositionDTO request, int id)
        {
            return Ok(positionService.Update(request, id));
        }

        [HttpPost("HasApply")]
        public ActionResult HasApply(ApplyRequestDTO request)
        {
            return Ok(positionService.HasApplied(request));
        }

        [HttpPost("Apply")]
        public ActionResult Apply(ApplyRequestDTO request)
        {
            positionService.Apply(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(positionService.Delete(id));
        }
    }
}
