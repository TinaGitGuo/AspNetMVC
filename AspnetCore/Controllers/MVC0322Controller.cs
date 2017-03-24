using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Controllers
{
    public class MVC0322Controller : Controller
    {
        Data.ApplicationDbContext db;

        public MVC0322Controller(Data.ApplicationDbContext _db) {
            db = _db;

        }
        // GET: MVC0308     
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View(); //Start
        }

        [HttpPost]
        public PartialViewResult _PartialStepOne(Contact1 one)
        {
            //...
            //db.BookMasters.Add(one);
            //db.SaveChanges();
            return PartialView("~/Views/MVC0308/_PartialStepTwo.cshtml");
        }
        [HttpPost]
        public PartialViewResult _PartialStepTwo(Contact4 two)
        {
            //...
            //db.Publisher.Add(two);
            //db.SaveChanges();
            return PartialView("~/Views/MVC0308/_PartialStepThree.cshtml");
        }
        //[HttpPost]
        //public ActionResult _PartialStepThree(Students Three)
        //{
        //    //...
        //    //db.Students.Add(Three);
        //    //db.SaveChanges();
        //    return Redirect("...");//done
        //}

   


    }
}