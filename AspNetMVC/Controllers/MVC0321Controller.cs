using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using Microsoft.AspNet.Identity;
namespace AspNetMVC.Controllers
{
    public class MVC0321Controller : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        // GET: MVC0321
        public ActionResult Index()
        {
            string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strUrl);
            
            return View(db.BookMasters.FirstOrDefault());
        }
        public ActionResult Index2()
        {         
            return PartialView("Index2");
        }
    }
}