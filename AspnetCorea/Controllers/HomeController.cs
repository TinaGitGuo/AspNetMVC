using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AspnetCorea.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
        public IActionResult Core0206a()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Core0206a(FormCollection form, string[] a, string[] b)
        {
            var t = Request.Form["a"];
            var h = Request.Form["b"];
            Microsoft.Extensions.Primitives.StringValues c = new Microsoft.Extensions.Primitives.StringValues("");
            List<string> g = new List<string>();
            form.TryGetValue("a", out c);
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
    }
}
