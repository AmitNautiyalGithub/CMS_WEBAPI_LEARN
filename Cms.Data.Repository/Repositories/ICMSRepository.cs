using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cms.Data.Repository
{
    public interface ICMSRepository
    {
        IEnumerable<Course> GetAllCourses();

        Task<IEnumerable<Course>> GetAllCoursesAsync();
    }
}