using Eevent.Models;
using Event.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            CategoryEev = new CategoryRpository(_db);
            evenTypeRp = new EvenTypeRpository(_db);

        }


        public ICategoryRpository CategoryEev { get; private set; }

        public IEvenTypeRpository evenTypeRp { get; private set; }

        public void Save()
        {

            _db.SaveChanges();


        }
    }
}
