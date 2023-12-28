using PortF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Data.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _db;
        public BlogRepository(AppDbContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            BlogModel Blog = _db.Blogs.Find(id);
            if (Blog != null)
            {
                _db.Blogs.Remove(Blog);
            }
        }

        public List<BlogModel> GetAll()
        {
            return _db.Blogs.ToList();
        }

        public BlogModel GetById(int id)
        {
            return _db.Blogs.Find(id);
        }

        public void Update(BlogModel model)
        {
            _db.Blogs.Update(model);
        }

    }
}
