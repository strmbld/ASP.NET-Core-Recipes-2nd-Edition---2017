using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class AlertTag
    {
        public int AlertTagId { get; set; }
        public int AlertId { get; set; }
        public string Tag { get; set; }

        public virtual Alert Alert { get; set; }
    }
}
