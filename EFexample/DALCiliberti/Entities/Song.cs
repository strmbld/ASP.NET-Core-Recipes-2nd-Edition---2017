using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Song
    {
        public Song()
        {
            BandAuditions = new HashSet<BandAudition>();
            PlaylistItems = new HashSet<PlaylistItem>();
            SongComments = new HashSet<SongComment>();
        }

        public int SongId { get; set; }
        public int MediaId { get; set; }
        public string SongTitle { get; set; }
        public int? ReleaseYear { get; set; }
        public string ArtworkUrl { get; set; }
        public string Lyrics { get; set; }
        public string SongDescription { get; set; }
        public string ActionParameter { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public int? GenreId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? ShowInLibrary { get; set; }

        public virtual Medium Media { get; set; }
        public virtual ICollection<BandAudition> BandAuditions { get; set; }
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; }
        public virtual ICollection<SongComment> SongComments { get; set; }
    }
}
