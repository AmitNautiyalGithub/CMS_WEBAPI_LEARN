using System.Collections.Generic;
using Cms.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        public ICMSRepository _cmsRepository { get; }

        public CoursesController(ICMSRepository cmsRepository)
        {
            _cmsRepository = cmsRepository;
        }



        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _cmsRepository.GetAllCourses();
        }




    }
}