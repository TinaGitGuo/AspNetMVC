using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        //private DataClasses1DataContext context = new DataClasses1DataContext();
        //private HoldingsContext db = new HoldingsContext();

        public List<SelectListItem> GetSelectListItem()
        {
            return new List<SelectListItem>()
                {
                new SelectListItem(){Text="null",Value=""},
                new SelectListItem(){Text="one",Value="001"},
                new SelectListItem(){Text="two",Value="002",Selected=true}
                 };
        }
        // GET: Reports/ClientInvestmentsSince
        public ActionResult ClientInvestmentsSince()
            { 
              
                ViewData["client"] = GetSelectListItem(); ;

                //ViewBag.SortedFunds = new SelectList(db.Ports.ToList().GroupBy(c => c.Fund).Select(g => g.First()), "Fund", "Fund");

                return View();
            }

            //[HttpGet]
            //public ActionResult Edit()
            //{
            //    //Id++;
            //    return View();
            //}


            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Create([Bind(Include = "ID,LastName,Fund,PurchaseDate,Shares,PurchasePrice,PurchaseAmount")] Investments investments)
            //{
            //    if (ModelState.IsValid)
            //    {



            //        //db.Ports.Add(movie);
            //        //db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    return View(investments);
            //}
            //public JsonResult ClientInvestmentsSince2(int Id)
            //{
                //string str = @"Data Source=USER\SQLEXPRESS;Initial Catalog=HoldingsConnectionString2;Integrated Security=True";
                //SqlConnection con = new SqlConnection(str);
                //string query = "select ID, Fund from Investments where Client_ID = " + Id;
                //SqlCommand cmd = new SqlCommand(query, con);
                //con.Open();
                //SqlDataReader rdr = cmd.ExecuteReader();
                //List<SelectListItem> li = new List<SelectListItem>();
                //while (rdr.Read())
                //{
                //    li.Add(new SelectListItem { Text = rdr["ID"].ToString(), Value = rdr["Fund"].ToString() });
                //}
                //ViewData["Fund"] = li;

                //// var theFunds = context.GetTable<Investment>();



                //return Json(li, JsonRequestBehavior.AllowGet);
            //}
        }
}