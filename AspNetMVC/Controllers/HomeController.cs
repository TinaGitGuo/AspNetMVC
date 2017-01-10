using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        CodeFirstDbDemoEntities db = new CodeFirstDbDemoEntities();
        public static List<Publisher> GetPublishers()
        {
            return new List<Publisher>{
                new Publisher{PublisherId="1", PublisherName="Volvo"         },
                new Publisher{PublisherId="2", PublisherName="Mercedes-Benz"  },
                new Publisher{PublisherId="3", PublisherName="Saab"          },
                new Publisher{PublisherId="4", PublisherName="Audi"         },
                new Publisher{PublisherId="5", PublisherName="Audi2"          }
                };
        }
        public ActionResult Index()
        {
            var ui = db.BookMasters.ToList();
            //var model = db.BookMasters.Where(u => u.Id == 1).FirstOrDefault();

            List<Publisher> listP=new List<Publisher> ();
            List<Publisher> listP2 = GetPublishers();
            var model = db.BookMasters.Where(u => u.Id == 1).FirstOrDefault();

            db.BookMasters.Where(u => u.Id == 1).FirstOrDefault().Publishers.ToList();
            foreach (var p in model.Publishers)
            {
                listP.Add(new Publisher() { PublisherId = p.PublisherId ,PublisherName=p.PublisherName});
            }
            // ..ToList().Select(i=>i.FirstOrDefault()) ;
            //x.Publishers.Select(c => new Publisher() { PublisherId = c.PublisherId, PublisherName = c.PublisherName }
            //var pus = (from a in model select a.Publishers).Select(r=>r);
         //   SelectList Publishers = new SelectList(listP as List<Publisher>,  "PublisherId", "PublisherName", 2);
            SelectList Publishers = new SelectList(db.BookMasters.Where(u => u.Id == 1).FirstOrDefault().Publishers  , "PublisherId", "PublisherName", 2);
            ViewData["list"] = Publishers;
            return View(model );
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
             
            return View();
        }
        //If UnAssignedGroupList  Is a property  in  MyViewModel class and please refer to code below:
public class MyViewModel
        {
            [Required(ErrorMessage = " At least one unassgined group is Required.")]
            public string UnAssignedGroupList { get; set; }

        }
       

//If not:
//In controller.cs :
     [HttpPost]
    public ActionResult Index0110(string UnAssignedGroupList)
        {
            if (!string.IsNullOrEmpty(UnAssignedGroupList))
            {
                ModelState.AddModelError("strBookTypeId ", " At least one unassgined group is Required.");
            }
            return View();
        }

        public ActionResult Index0110()
        {
            //At least one unassgined group is Required.
            ViewBag.Message = "Your contact page.";
            var model = db.BookMasters.Where(u => u.Id == 1).FirstOrDefault();
            return View(model);
        }
    }
}