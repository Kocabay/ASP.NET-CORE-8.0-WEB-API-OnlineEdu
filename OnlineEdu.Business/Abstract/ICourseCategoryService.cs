using OnlineEdu.Entity.Entities;
using System;

namespace OnlineEdu.Business.Abstract
{
    public interface ICourseCategoryService:IGenericService<CourseCategory>
    {
        void TShowOnHome(int id);
        void TDontShowOnHome(int id);
    }
}
