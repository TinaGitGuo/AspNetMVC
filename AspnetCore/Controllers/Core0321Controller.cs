using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Xml;

namespace AspnetCore.Controllers
{
    public class Core0321Controller : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            //Startup.connectionString = "FR";
            return View();
        }
        public IActionResult Index2()
        {
           
            return View();
        }
    }
}