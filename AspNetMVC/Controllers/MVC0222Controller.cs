using Microsoft.ReportingServices.DataProcessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0222Controller : Controller
    {
        // GET: MVC0222
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult YourMethodName()
        {
            // Your data connection and query stuff here
            List<string> result = new List<string>();
            result.Add("1");
            result.Add("2");
            result.Add("3");
            // Return your JSON here
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index2() {
            return View();
        }
        public ActionResult Index3() {
           
            return View();
        }
    }
}