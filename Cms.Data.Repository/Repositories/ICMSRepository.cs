namespace Cms.Data.Repository
{
    public interface ICMSRepository
    {
        IEnumerable<Course> GetAllCourses();
    }
}