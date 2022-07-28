using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.ViewComponents.ArtistCardViewComponent
{
    public class ArtistCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Artist artist)
        {
            return View(artist);
        }
    }
}
