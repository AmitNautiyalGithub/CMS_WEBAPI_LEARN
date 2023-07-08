using System;
using System.Collections.Generic;

namespace Cms.Data.Repository
{
    public class InMemoryCmsRepository : ICMSRepository
    {
        List<Course> _courses = null;

        public InMemoryCmsRepository()
        {
            _courses = new List<Course>();

            _courses.Add(new Course
            {
                CourseId = 1,
                CourseName = "Computer Science",
                CourseDuration = 4,
                CourseType = COURSE_TYPE.ENGINEERING
            });

            _courses.Add(new Course
            {
                CourseId = 2,
                CourseName = "Information Technology",
                CourseDuration = 4,
                CourseType = COURSE_TYPE.ENGINEERING
            });
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courses;
        }
    }
}