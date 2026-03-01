namespace OnlineEdu.WebUI.DTOs.CourseDtos
{
    public class UpdateCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
