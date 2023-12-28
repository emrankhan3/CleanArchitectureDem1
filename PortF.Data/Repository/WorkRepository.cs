using PortF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Data.Repository
{
    public class WorkRepository : IWorkRepository
    {
        private readonly AppDbContext _db;
        public WorkRepository(AppDbContext db)
        {
            _db= db;
        }
        public void Delete(int id)
        {
            WorkModel work = _db.Works.Find(id);
            if(work != null)
            {
                _db.Works.Remove(work);
            }
        }

        public List<WorkModel> GetAll()
        {
            return _db.Works.ToList();
        }

        public WorkModel GetById(int id)
        {
            return _db.Works.Find(id);
        }

        public void Update(WorkModel model)
        {
            _db.Works.Update(model);
        }
    }
}
