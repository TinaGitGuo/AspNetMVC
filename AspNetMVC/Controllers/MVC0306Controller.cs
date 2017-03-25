using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0306Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0306
        public ActionResult Index()
        {
          var c=  (from r in db.BookMasters
             where r.Id==1
             && r.Id == 1
             select new { r.Id }).Single();


            db.BookMasters.Where(m => m.Id == 1).Single();
            db.BookMasters.Find(1 );
            return View();
        }
 
    }
}