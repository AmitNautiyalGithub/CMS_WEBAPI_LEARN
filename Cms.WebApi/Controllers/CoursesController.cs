using Microsoft.AspNetCore.Mvc;

namespace Cms.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        public readonly ICMSRepository CmsRepository { get; }

        public CoursesController(ICMSRepository cmsRepository)
        {
            CmsRepository = cmsRepository;
        }



        [HttpGet]
        public string GetCourses()
        {
            return "Hello, world";
        }




    }
}