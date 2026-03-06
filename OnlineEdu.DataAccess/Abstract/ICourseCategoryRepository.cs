using OnlineEdu.Entity.Entities;
using System;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseCategoryRepository:IRepository<CourseCategory>
    {
        void ShowOnHome(int id);
        void DontShowOnHome(int id);
    }
}
