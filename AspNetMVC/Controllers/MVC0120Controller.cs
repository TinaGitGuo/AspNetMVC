using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0120Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0120
        public ActionResult Index()
        {
            return View();
        }

        // GET: MVC0117
        public ActionResult Index2()
        {

            return View(db.BookMasters.ToList());
        }
        public void ToGetCount(List<int> timelist, out int counta, out int countb, out int countc)
        {
            counta = countb = countc = 0;
            foreach (int c in timelist)
            {
                DateTime _time = System.DateTime.Now;
                int _time_num = Convert.ToInt32(_time.Hour);
                if ((_time_num  >= 0 ) && (_time_num < 12))
                {
                    counta++;
                    //return   true; 
                }
                else if ((_time_num >= 12) && (_time_num < 18))
                {
                    countb++;
                    //return   false; 
                }
                else if ((_time_num >= 18) && (_time_num <=23))
                {
                    countc++;
                }
            }
        }


        public ActionResult Index3()
        {
             
            return View(db.BookMasters.ToList());
        }
        public ActionResult Index4()
        { int c = 0;
            int counta, countb, countc;
            /*  List<int> timelist*//* =*/

          counta=  db.BookMasters.Where(o => o.Id  > 0 && o.Id<15).Count() ;
            //ToGetCount(timelist, out counta, out countb, out countc);
            return View();
        }
        public ActionResult Index5()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index5(FormCollection form)
        {
            return View();
        }
         
        public ActionResult Index6()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index6(string param1, string param2, string param3) //4 into post page
        {
            if (ModelState.IsValid)
            {
                //perform a linq query to get report
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}