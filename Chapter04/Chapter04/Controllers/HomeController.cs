using Chapter04.Models;
using Chapter04.Services.Logging;
using Chapter04.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppLogging<HomeController> _logger;

        public HomeController(IAppLogging<HomeController> logger)
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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ActionLinks()
        {
            return View();
        }

        public IActionResult FormTagHelpers()
        {
            AdvancedContact model = new() { AllowContactSpecialOffers = true };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FormTagHelpers(AdvancedContact model)
        {
            if (ModelState.IsValid)
            {
                return View("FormTagHelpersThanks", model);
            }

            return View(model);
        }

        public IActionResult SelectTag()
        {
            GuitarBrandViewModel m = new()
            {
                Brands = new List<SelectListItem>()
                {
                    new SelectListItem(){ Value="",Text = "Select a brand"},
                    new SelectListItem(){ Value="1",Text = "Gibson"},
                    new SelectListItem(){ Value="2",Text = "Charvel"},
                    new SelectListItem(){ Value="3",Text = "Ibanez"},
                    new SelectListItem(){ Value="4",Text = "Jackson"},
                },
            };

            return View(m);
        }

        [HttpPost]
        public IActionResult SelectTag(GuitarBrandViewModel model)
        {
            model.Brands = new List<SelectListItem>()
            {
                new SelectListItem(){ Value="",Text = "Select a brand"},
                new SelectListItem(){ Value="1",Text = "Gibson"},
                new SelectListItem(){ Value="2",Text = "Charvel"},
                new SelectListItem(){ Value="3",Text = "Ibanez"},
                new SelectListItem(){ Value="4",Text = "Jackson"},
            };

            if (model.SelectedBrandId != 0)
            {
                model.SelectedBrand = (from b in model.Brands
                                       where b.Value == model.SelectedBrandId.ToString()
                                       select new GuitarBrand
                                       {
                                           Id = int.Parse(b.Value),
                                           Name = b.Text,
                                       }).FirstOrDefault();
            }

            return View(model);
        }

        public IActionResult Validation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validation(ContactForValidation model)
        {
            if (ModelState.IsValid)
            {
                return View("ValidationThanks");
            }

            return View();
        }

        public IActionResult CacheSelectList()
        {
            var model = new FormWithCacheViewModel { MyListIsCached = "Nothing" };
            return View(model);
        }

        [HttpPost]
        public IActionResult CacheSelectList(FormWithCacheViewModel model)
        {
            return View(model);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult TagCloud()
        {
            return View();
        }
    }
}
