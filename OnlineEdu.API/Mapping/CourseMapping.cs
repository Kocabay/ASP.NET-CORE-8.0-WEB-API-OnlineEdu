using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<ResultCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<CreateCourseDto, Course>().ReverseMap();
        }
    }
}
