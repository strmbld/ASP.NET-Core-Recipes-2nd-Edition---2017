using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class EmailOptOut
    {
        public string EmailAddress { get; set; }
        public DateTime DateOfOptOut { get; set; }
    }
}
