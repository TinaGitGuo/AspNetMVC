using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0209Controller : Controller
    {
        // GET: MVC0209
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public class yy {
            public string txt1 { get; set; }
            public string txt2 { get; set; }
        }
        [HttpPost]
        public ActionResult Index2(yy yys)
        {
            return View();
        }
    }
}