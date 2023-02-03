

using Eevent.Models;
using Event.DataAccess.Repository.IRepository;

using Microsoft.AspNetCore.Mvc;

namespace EeventWebApplication.Areas.Admin.Controllers
{


    /*
     * define admin area
     */

    [Area("Admin")]
                 
    public class ProductEventTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        /*
         *  to retrieve data from database 
         *  
         */


        public ProductEventTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductEvents> Event = _unitOfWork.ProductEev.GetAll();

            return View(Event);
        }

        // get method 
        public IActionResult Create()
        {


            return View();
        }

        // Post method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventsTypes obj)
        {
            /*
             * this is how to retrieve category from db and we must add savechanges to save post data to database  
             * adding validation for server side , here if the model is valid so redirect to index !
             * 
             */

         

            if (ModelState.IsValid)
            {

             //   _unitOfWork.evenTypeRp.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "EventsTypes created successfuly";
                // here i directed the view to index view,
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        // Edit method
        /*
            *  retrieve data base on id to edit it  
            * 
            * 
            */
        public IActionResult Edit(int? id)
        {
            /*
             * first we need to check id if null or not 
             * 
            */
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // var categoryFromDb = _db.categoryEevents.Find(id);
            var categoryFrom = _unitOfWork.evenTypeRp.GetFirstOrDefault(e => e.Id == id);
            //var categoryFromSingle = _db.categoryEevents.SingleOrDefault(e => e.Id == id);

            if (categoryFrom == null)
            {
                return NotFound();
            }
            return View(categoryFrom);
        }




        // Update method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventsTypes obj)
        {
            /*
             * this is how to retrieve category from db and we must add savechanges to save post data to database  
             * adding validation for server side , here if the model is valid so redirect to index !
             * 
             */


            if (ModelState.IsValid)
            {



             //   _unitOfWork.evenTypeRp.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "EventsTypes updated successfuly";

                // here i directed the view to index view,
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        // delete method


        public IActionResult Delete(int? id)
        {
            /*
             * first we need to check id if null or not 
             * 
            */
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // var categoryFromDb = _db.categoryEevents.Find(id);
            var categoryFrom = _unitOfWork.evenTypeRp.GetFirstOrDefault(e => e.Id == id);
            //var categoryFromSingle = _db.categoryEevents.SingleOrDefault(e => e.Id == id);

            if (categoryFrom == null)
            {
                return NotFound();
            }
            return View(categoryFrom);
        }




        // delete method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            /*
             * this is how to retrieve category from db and we must add savechanges to save post data to database  
             * adding validation for server side , here if the model is valid so redirect to index !
             * 
             */

            var obj = _unitOfWork.evenTypeRp.GetFirstOrDefault(e => e.Id == id);

            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.evenTypeRp.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "EventsTypes deleted successfuly";
            // here i directed the view to index view,
            return RedirectToAction("Index");


        }

    }
}
