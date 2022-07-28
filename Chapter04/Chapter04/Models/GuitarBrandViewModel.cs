using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Models
{
    public class GuitarBrandViewModel
    {
        public List<SelectListItem> Brands { get; set; }

        public int SelectedBrandId { get; set; }

        public GuitarBrand SelectedBrand { get; set; }
    }
}
