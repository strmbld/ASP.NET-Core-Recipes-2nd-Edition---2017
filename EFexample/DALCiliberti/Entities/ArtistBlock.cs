using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class ArtistBlock
    {
        public int ArtistBlockId { get; set; }
        public int ArtistId { get; set; }
        public int BlockedArtistId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool ReportAsSpammer { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
