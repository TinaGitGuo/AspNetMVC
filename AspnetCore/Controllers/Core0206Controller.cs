using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore.Controllers
{
    public class Core0206Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}