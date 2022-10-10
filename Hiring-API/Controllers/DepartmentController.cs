using BLL.DTOs.Department;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(departmentService.GetAll());
        }

        [HttpGet("GetAllActive")]
        public ActionResult GetAllActive()
        {
            return Ok(departmentService.GetAllActive());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(departmentService.GetById(id));
        }

        [HttpPost]
        public ActionResult Create(CreateDepartmentDTO request)
        {
            return Ok(departmentService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreateDepartmentDTO request, int id)
        {
            return Ok(departmentService.Update(request, id));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(departmentService.Delete(id));
        }
    }
}
