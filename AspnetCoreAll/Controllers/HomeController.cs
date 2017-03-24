using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreAll.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strUrl);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
