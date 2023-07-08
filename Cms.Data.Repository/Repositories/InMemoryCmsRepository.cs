using System;
using System.Collections.Generic;

namespace Cms.Data.Repository
{
    public class InMemoryCmsRepository : ICMSRepository
    {
        public InMemoryCmsRepository()
        {

        }

        public IEnumerable<Course> GetAllCourses()
        {
            return null;
        }
    }
}