using PortF.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Services
{
    public class BlogServices
    {
        private readonly IBlogRepository blogRepository;

        public BlogServices(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

    }
}
