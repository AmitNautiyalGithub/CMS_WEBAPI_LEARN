using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cms.Data.Repository
{
    public class SqlCmsRepository : ICMSRepository
    {
        public IEnumerable<Course> GetAllCourses()
        {
            return null;
        }

        public Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            throw new NotImplementedException();
        }
    }
}