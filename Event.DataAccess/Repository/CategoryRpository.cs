
using Eevent.Models;
using Event.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository
{
    public class CategoryRpository : Repository<CategoryEevent>, ICategoryRpository
    {
        private ApplicationDbContext _db;

        public CategoryRpository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

       

        public void Update(CategoryEevent obj)
        {
            _db.categoryEevents.Update(obj);
        }
    }
}
