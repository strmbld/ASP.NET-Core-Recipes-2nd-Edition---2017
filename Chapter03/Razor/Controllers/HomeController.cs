using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            ViewBag.Message = "ASP.NET MVC samples";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "email to strmbld@gmail.com with any questions";
            return View();
        }

        public IActionResult Control()
        {
            Guitar model = new()
            {
                Brand = "Charvel",
                Model = "Metal Shredder",
                WhammyBarType = "Floyd Rose",
                Description = "Death to all but metal",
                Strings = new List<string> { "E", "A", "D", "G", "B", "E" },
                HasWhammyBar = true,
            };

            return View(model);
        }

        public IActionResult Variables()
        {
            Guitar g = new()
            {
                Brand = "Gibson",
                Model = "Les Paul",
                Description = "Very cool guitar",
                Strings = new List<string> { "E", "A", "D", "G", "B", "E" },
                HasWhammyBar = false,
            };

            return View(g);
        }

        public IActionResult Loops()
        {
            List<Guitar> ls = new()
            {
                new() { Brand = "Fender", Model = "Strat", HasWhammyBar = true },
                new() { Brand = "Gibson", Model = "Les Paul", HasWhammyBar = false },
                new() { Brand = "Charvel", Model = "Metal", HasWhammyBar = true },
                new() { Brand = "Fender", Model = "Telecaster", HasWhammyBar = false },
            };

            return View(ls);
        }

        public IActionResult HtmlHelper()
        {
            Guitar g = new()
            {
                Brand = "Gibson",
                Model = "Les Paul",
                HasWhammyBar = false,
            };

            return View(g);
        }

        [HttpPost]
        public IActionResult HtmlHelper(Guitar obj)
        {
            if (ModelState.IsValid)
            {
                return View("GuitarSaved", obj);
            }
            return View(obj);
        }

        public IActionResult CodeBlocks()
        {
            return View();
        }

        public IActionResult CodeNuggets()
        {
            var model = new Product();
            model.Id = 123;
            return View(model);
        }

        public IActionResult ExplicitMarkup()
        {
            Guitar g = new()
            {
                Brand = "Gibson",
                Model = "Les Paul",
                Strings = new List<string> { "E", "A", "D", "G", "B", "E" }
            };

            return View(g);
        }

        public IActionResult Comments()
        {
            return View();
        }

        public IActionResult StandardHtmlHelpers()
        {
            return View();
        }

        public IActionResult StronglyTypedHtmlHelpers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypedHtmlHelpers(LoginViewModel model)
        {
            return View(model);
        }

        public IActionResult TemplatedHtmlHelpers(LoginViewModel model)
        {
            return View(model);
        }

        public IActionResult InlineFunctions()
        {
            return View();
        }
    }
}
