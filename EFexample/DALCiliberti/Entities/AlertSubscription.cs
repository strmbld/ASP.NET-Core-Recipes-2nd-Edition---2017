using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class AlertSubscription
    {
        public int AlertSubscriptionId { get; set; }
        public int ArtistId { get; set; }
        public string Tags { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
