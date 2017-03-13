using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0308Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0308
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Index2() {
            return View();
        }
        public ActionResult Index3() {
            return View(db.BookMasters.ToList());
        }


        public ActionResult Index4()
        {
            return View( );
        }
        
        [HttpPost]
           public PartialViewResult _PartialStepOne(BookMaster one)
        {
            //...
            //db.BookMasters.Add(one);
            //db.SaveChanges();
            return PartialView("~/Views/MVC0308/_PartialStepTwo.cshtml");
        }
        [HttpPost]
        public PartialViewResult _PartialStepTwo(Publisher two)
        {
            //...
            //db.Publisher.Add(two);
            //db.SaveChanges();
            return PartialView("~/Views/MVC0308/_PartialStepThree.cshtml");
        }
        [HttpPost]
        public ActionResult _PartialStepThree(BookMaster Three)
        {
            //...
            //db.BookMasters.Add(Three);
            //db.SaveChanges();
            return Redirect("...");//done
        }

         
    }
}