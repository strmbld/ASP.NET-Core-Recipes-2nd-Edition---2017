using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter04.Models
{
    public class TagCloudItem
    {
        public string Url { get; set; }

        public int Weight { get; set; }

        public string DisplayText { get; set; }
    }
}
