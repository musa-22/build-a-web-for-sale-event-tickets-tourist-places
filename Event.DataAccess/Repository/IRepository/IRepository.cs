using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository.IRepository
{
    public interface IRepository <T> where T : class
    {
        // create generic interface repo class to handle all of classess 12/01/23 

        T GetFirstOrDefault(Expression<Func<T, bool>> filter);


        //T - category

        IEnumerable<T> GetAll ();


        // add 
        void Add (T entity);

        void Remove(T entity);

        //remove more than 1 entity will use remove range 

        void RemoveRange(IEnumerable<T> entities);




    }
}
