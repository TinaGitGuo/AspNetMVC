using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0126Controller : Controller
    {
        private CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0126

        public class Employee
        {
          
            public int Id { get; set; }

            public string EName { get; set; }

            public string Address { get; set; }

            public Gender Gender { get; set; }

        }

        public enum Gender
        {
            Male,
            Female,
            Other
        }
        public ActionResult Index()
        {
            sex field = sex.man;
            ViewBag.field = field;

            
            return View(new Employee() { Gender = Gender.Male });
        }
        public enum sex {
            female=1,
            man
        }
        public ActionResult Index2()
        {
            
            ViewBag.SortedClients =new SelectList(   new List<SelectListItem>() { new SelectListItem() { Text = "c", Value = "1" } } ,"Value","" );
            ViewBag.c = "1";
           ViewBag.c= GetClientTime("+08 00");
            return View();
        }
        public DateTime GetClientTime(string clientTimeOffset)
        {
            
            //clientTimeOffset: "+08 00"             
            DateTime utcTime = DateTime.UtcNow; //1 / 26 / 2017 7:33:02 AM           
            string[] timeOffset = clientTimeOffset.Split(' ');
            int hourOffset = int.Parse(timeOffset[0]);
            int minuteOffset = int.Parse(timeOffset[1]);          
            utcTime = utcTime.AddHours(hourOffset);            
            utcTime = utcTime.AddMinutes(minuteOffset);
            return utcTime;  // return custom time : 1 / 26 / 2017 3:33:02 PM
        }
    }
}