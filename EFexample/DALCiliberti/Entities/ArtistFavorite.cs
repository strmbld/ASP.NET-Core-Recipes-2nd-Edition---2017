using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class ArtistFavorite
    {
        public int ArtistFavoriteId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public int? ItemId { get; set; }
        public int Category { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
