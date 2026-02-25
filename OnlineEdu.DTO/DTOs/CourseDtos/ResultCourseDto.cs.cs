
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public ResultCourseCategoryDto  CourseCategoryDto { get; set; }
        public Decimal Price { get; set; }
        public bool IsShown { get; set; }

    }
}
