using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace AspNetMVC.Controllers
{
    public class MVC0321Controller : Controller
    {
        // GET: MVC0321
        public ActionResult Index()
        {
            string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strUrl);
            return View();
        }
    }
}