using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0217Controller : Controller
    {
        // GET: MVC0217
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2() {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegistration( )
        {
            //if (ModelState.IsValid)
            //{
                return Json("Registration Success", JsonRequestBehavior.AllowGet);
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}