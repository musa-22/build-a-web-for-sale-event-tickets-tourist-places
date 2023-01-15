
using Eevent.Models;
using Event.DataAccess.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository
{
    public class EvenTypeRpository : Repository<EventsTypes>, IEvenTypeRpository
    {
        private ApplicationDbContext _db;

        public EvenTypeRpository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

       

        public void Update(EventsTypes obj)
        {
            _db.eventsTypes.Update(obj);
        }
    }
}
