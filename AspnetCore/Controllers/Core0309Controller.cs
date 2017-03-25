using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspnetCore.Data;
using AspnetCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetCore.Controllers
{
    public class Core0309Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Core0309Controller(ApplicationDbContext context)
        {
           
            _context = context;
        }
       
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            //ViewData["InspectDate"] = new DateTime();
            //ViewData["ConditionID"] = new SelectList(_context.Conditions.OrderBy(e => e.EqCondition), "ConditionID", "EqCondition");
            //ViewData["EqTypeID"] = new SelectList(_context.EqTypes.OrderBy(e => e.EquipmentType), "EqTypeID", "EquipmentType");
            //ViewData["MakeID"] = new SelectList(_context.Makes.OrderBy(m => m.EqMake), "MakeID", "EqMake");
            //ViewData["SiteID"] = new SelectList(_context.Sites.OrderBy(s => s.SiteName), "SiteID", "SiteName");
            ViewData["Accountno"] = new SelectList(_context.Contact1ss , "Accountno", "Company");
            ViewData["Company"] = new SelectList(_context.Contact1ss, "Company", "Accountno");
            
            return View();
        }
        public IActionResult GetWaterBody(int siteID)
        {
            var waterBody = new List<Contact1>();


            waterBody = getWaterBodyFromDataBaseBySiteID(siteID);



            return Json(waterBody);

        }

        public List<Contact1> getWaterBodyFromDataBaseBySiteID(int siteID)
        {
            return _context.Contact1ss.ToList();
        }
    }
}
