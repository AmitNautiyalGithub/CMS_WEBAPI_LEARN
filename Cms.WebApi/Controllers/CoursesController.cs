using Microsoft.AspNetCore.Mvc;

namespace Cms.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        public CoursesController()
        {

        }

        [HttpGet]
        public string GetCourses()
        {
            return "Hello, world";
        }




    }
}