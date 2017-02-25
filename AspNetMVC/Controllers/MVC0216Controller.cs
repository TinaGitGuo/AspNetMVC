using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0216Controller : Controller
    {
        // GET: MVC0216
        public ActionResult Index()
        {
            

            //ViewEngines.Engines.Clear();
            ////Add Razor Engine
            //ViewEngines.Engines.Add(new RazorViewEngine());
            return View();
        }
    }
}