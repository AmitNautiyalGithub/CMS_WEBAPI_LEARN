namespace Cms.WebApi.DTOs
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public COURSE_TYPE_Dto CourseType { get; set; }
    }


    public enum COURSE_TYPE_Dto
    {
        ENGINEERING,
        MEDICAL,
        MANAGEMENT
    }
}