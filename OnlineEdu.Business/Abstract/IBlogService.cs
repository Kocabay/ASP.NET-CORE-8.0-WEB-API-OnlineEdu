using OnlineEdu.Entity.Entities;
using System;

namespace OnlineEdu.Business.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
    }
}
