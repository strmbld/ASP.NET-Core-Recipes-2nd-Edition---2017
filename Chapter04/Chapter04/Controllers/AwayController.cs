using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Controllers
{
    public class AwayController : Controller
    {
        public IActionResult Somewhere()
        {
            ViewBag.Message = "This is a sample Website for something cool.";

            return View();
        }
    }
}
