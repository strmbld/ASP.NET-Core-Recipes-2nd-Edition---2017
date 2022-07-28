using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class AwayController : Controller
    {
        public IActionResult Somewhere()
        {
            ViewBag.Message = "AwayController.Somewhere()";

            return View();
        }
    }
}
