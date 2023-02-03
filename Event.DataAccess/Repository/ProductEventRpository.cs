
using Eevent.Models;
using Event.DataAccess.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DataAccess.Repository
{
    public class ProductEventRpository : Repository<ProductEvents>, IProductEventRpository
    {
        private ApplicationDbContext _db;

        public ProductEventRpository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

       

        public void Update(ProductEvents obj)
        {

            // having bugs where update all product rather than update selected product??
            //  _db.Products.Update(obj);

            // issues solved
            // update product based on selection 
            var objFromDb = _db.Products.FirstOrDefault(u =>u.Id== obj.Id);
            if(objFromDb == null)
            {
                objFromDb.Tile = obj.Tile;
                objFromDb.price = obj.price;
                objFromDb.listPrice = obj.listPrice;
                objFromDb.Description = obj.Description;
                objFromDb.EventsTypesId = obj.EventsTypesId;
                
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }


            }

        }
    }
}
