using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class ArtistBand
    {
        public int ArtistBandId { get; set; }
        public int ArtistId { get; set; }
        public int? BandId { get; set; }
        public string Role { get; set; }
        public DateTime JoinedDate { get; set; }
        public bool? IsActiveMember { get; set; }
        public DateTime? DeactivateDate { get; set; }
        public bool AllowEditBand { get; set; }
        public bool IsMemberAdmin { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
    }
}
