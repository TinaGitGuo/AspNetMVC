using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class MVC0202Controller : Controller
    {
        // GET: MVC0202
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetImage() {
          //  http://www.cnblogs.com/CareySon/archive/2012/03/07/2383690.html
            byte[] data = Convert.FromBase64String("GQ8XQAYFAiEMfN0qD0COTgMX");
            return File(data, "image/gif"); 
   //         return File("R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7", "data: image / gif; base64");
         //   return File("data: image / gif; base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7");
        }
    }
}