using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZAHikes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult getAllStudents()
        {
            string[] studentNames = new string[] { "Joe", "Piet", "Jack", "Chris", "Albanian" };
            return Ok(studentNames);
        }
    }
}
