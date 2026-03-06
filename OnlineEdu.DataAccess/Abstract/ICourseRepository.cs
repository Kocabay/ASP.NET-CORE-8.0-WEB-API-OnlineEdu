using OnlineEdu.Entity.Entities;
using System;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseRepository:IRepository<Course>
    {
        void ShowOnHome(int id);
        void DontShowOnHome(int id);

    }
}
