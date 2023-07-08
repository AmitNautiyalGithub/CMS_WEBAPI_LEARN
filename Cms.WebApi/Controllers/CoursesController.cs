using System.Collections.Generic;
using Cms.Data.Repository;
using Cms.WebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;

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



        //Return type - Approach 1 - Primitive or Complex type
        // [HttpGet]
        // public IEnumerable<Course> GetCourses()
        // {
        //     return _cmsRepository.GetAllCourses();
        // }


        //Return type - Approach 1 - Primitive or Complex type
        // [HttpGet]
        // public IEnumerable<CourseDto> GetCourses()
        // {
        //     try
        //     {
        //         IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
        //         var result = MapCourseToCourseDto(courses);
        //         return result;
        //     }
        //     catch (System.Exception)
        //     {
        //         throw;
        //     }
        // }

        //Return type - Approach 2  - IActionResult
        [HttpGet]
        public IActionResult GetCourses()
        {
            try
            {
                IEnumerable<Course> courses = _cmsRepository.GetAllCourses();
                var result = MapCourseToCourseDto(courses);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Custom mapper function
        private CourseDto MapCourseToCourseDto(Course course)
        {
            return new CourseDto
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                CourseDuration = course.CourseDuration,
                CourseType = (COURSE_TYPE_Dto)course.CourseType,
            };
        }


        private IEnumerable<CourseDto> MapCourseToCourseDto(IEnumerable<Course> courses)
        {
            IEnumerable<CourseDto> result;

            result = courses.Select(c => new CourseDto()
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                CourseDuration = c.CourseDuration,
                CourseType = (COURSE_TYPE_Dto)c.CourseType,
            });

            return result;
        }
    }
}