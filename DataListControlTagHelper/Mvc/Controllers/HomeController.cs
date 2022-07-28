using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
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
            DataTable dataTable = new();
            using (SqlConnection connection = new(
                @"Server=.,5433;Database=Mvc6RecipesSharedDb;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=true"))
            {
                string sql = "SELECT TOP(20) UserName, AvatarURL, Country, CreateDate, ProfileViews FROM [dbo].[Artist]";
                using (SqlCommand cmd = new(sql, connection))
                {
                    using (SqlDataAdapter dataAdapter = new(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            List<Artist> artists = new();
            foreach (var item in dataTable.AsEnumerable())
            {
                artists.Add(new Artist
                {
                    UserName = item.Field<string>("UserName"),
                    AvatarUrl = item.Field<string>("AvatarURL"),
                    Country = item.Field<string>("Country"),
                    CreateDate = item.Field<DateTime>("CreateDate"),
                    ProfileViews = item.Field<long>("ProfileViews"),
                });
            }

            return View(artists);
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
    }
}
