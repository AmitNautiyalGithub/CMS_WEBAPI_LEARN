namespace Cms.Data.Repository
{
    public class InMemoryCmsRepository : ICMSRepository
    {
        public InMemoryCmsRepository()
        {

        }

        public IEnumerable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }
    }
}