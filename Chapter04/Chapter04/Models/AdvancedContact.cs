using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Models
{
    public class AdvancedContact
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool? AllowContactSpecialOffers { get; set; }

        [Display(Name = "Favorite Color?")]
        public string FavoriteColor { get; set; }
    }
}
