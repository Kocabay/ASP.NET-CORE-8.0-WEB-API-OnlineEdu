using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using OnlineEdu.DataAccess.Repositories;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DataAccess.Concrete
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private readonly OnlineEduContext _educontext;
        public BlogRepository(OnlineEduContext _context, OnlineEduContext context) : base(_context)
        {
            this._educontext = context;
        }

        public List<Blog> GetBlogsWithCategories()
        {
            return _educontext.Blogs.Include(b => b.BlogCategory).ToList();
        }
    }
}
