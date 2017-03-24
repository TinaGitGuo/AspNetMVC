using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AspnetCorea.ViewComponents;
using System.Xml;

namespace AspnetCorea.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //string strUrl = "http://www.w3school.com.cn/example/xmle/note.xml";
            //XmlDocument doc = new XmlDocument();
            //doc.Load(strUrl);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            //new UserRole();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public class Class4
        {
            private int add(int num2, int num3)
            {
                int res = num2 + num3;
                return res;
            }

            private int obj1;

            public int myprop
            {
                get { return obj1; }
                set { obj1 = add(value, value); }
            }
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Core0206a()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Core0206a(FormCollection form, string[] a, string[] b,string c)
        {
            var t = Request.Form["a"];
            var h = Request.Form["b"];
            var y = Request.Form["c"];
            Microsoft.Extensions.Primitives.StringValues d = new Microsoft.Extensions.Primitives.StringValues("");
            List<string> g = new List<string>();
            form.TryGetValue("a", out d);
            return NotFound();
        }
        //    public bool ValiCheckForDuplicate(string str, string name)
        //    {
        //        if (!CheckForDuplicate(str))
        //        {
        //            ModelState.AddModelError("", name + " already exist");
        //            return true;
        //        }
        //        return false;
        //    }

        //    public IActionResult VersionOne(TestModel model)
        //    {

        //        if (!ModelState.IsValid || ValiCheckForDuplicate(model.Title, " name ") || ValiCheckForDuplicate(model.Title, " url "))
        //        {
        //            model.SelectList1 = GetSelectList1();
        //            model.SelectList2 = GetSelectList2();
        //            model.SelectList3 = GetSelectList3();
        //            return View(model);
        //        }


        //        if (string.IsNullOrEmpty(model.UrlFriendlyTitle))
        //            model.UrlFriendlyTitle = GenerateUrlFriendlyTitle(model.Title);


        //        // do something else
        //        // mapping and saving to database

        //        return RedirectToAction("Index");
        //    }

        public IActionResult Core0207a() {
            Class4 a = new Class4();
            a.myprop = 5;
            string b = a.myprop.ToString();
            return ViewComponent("PriorityList", new { maxPriority = 3, isDone = false });
            
        }
        [HttpPost]
        public ActionResult Method1()
        {
            return ViewComponent("PriorityList" );
        }
        public IActionResult Core0222() {
            return View();
        }
       
    }
}
