using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class PlayList
    {
        public PlayList()
        {
            PlaylistItems = new HashSet<PlaylistItem>();
        }

        public int PlaylistId { get; set; }
        public string Title { get; set; }
        public int? ArtistId { get; set; }
        public int? BandId { get; set; }
        public bool IsSitePlaylist { get; set; }
        public bool IsDefaultPlaylist { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Band Band { get; set; }
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; }
    }
}
