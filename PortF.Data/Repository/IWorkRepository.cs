using PortF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Data.Repository
{
    public interface IWorkRepository
    {
        List<WorkModel> GetAll();
        WorkModel GetById(int id);
        void Delete(int id);
        void Update(WorkModel model);
    }
}
