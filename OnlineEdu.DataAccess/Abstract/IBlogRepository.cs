using OnlineEdu.Entity.Entities;
using System;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IBlogRepository:IRepository<Blog>
    {
        List<Blog> GetBlogsWithCategories();
    }
}
