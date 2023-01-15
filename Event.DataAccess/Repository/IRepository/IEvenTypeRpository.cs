using Eevent.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository.IRepository
{
    public interface IEvenTypeRpository : IRepository<EventsTypes>
    {
        /*
         * updating function will be implemented here ?
         * calling category event oject here to update data 
         */

        void Update(EventsTypes obj);



    }
}
