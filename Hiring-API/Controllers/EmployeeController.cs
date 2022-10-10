using BLL.DTOs.Employee;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(employeeService.GetAll());
        }

        [HttpPost("GetAll")]
        public ActionResult GetAll(GetAllEmployeeDTO request)
        {
            return Ok(employeeService.GetAll(request));
        }

        [HttpPost]
        public ActionResult Hire(HireEmployeeDTO request)
        {
            return Ok(employeeService.Hire(request));
        }
    }
}
