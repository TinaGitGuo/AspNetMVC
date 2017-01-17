using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0117Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0117
        public ActionResult Index()
        {

            return View(db.BookMasters.ToList());
        }
        public bool Detal()
        {
            return true;
        }
        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(FormCollection form)
        {         
            foreach (var a in form.AllKeys)//form.Count=1
            {
                string key = a; //key=hdn_2
                string value= form[a]; //value=3
            }
            
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<BookMaster> Index5()
        {
            return db.BookMasters.ToList();
        }
    }
}