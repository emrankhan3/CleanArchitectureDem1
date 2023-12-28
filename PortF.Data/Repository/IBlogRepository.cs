using PortF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Data.Repository
{
    public interface IBlogRepository
    {
        List<BlogModel> GetAll();
        BlogModel GetById(int id);
        void Delete(int id);
        void Update(BlogModel model);
    }
}
