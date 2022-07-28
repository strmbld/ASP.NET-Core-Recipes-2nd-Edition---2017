using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Band
    {
        public Band()
        {
            ArtistBands = new HashSet<ArtistBand>();
            BandGenres = new HashSet<BandGenre>();
            CollaborationSpaces = new HashSet<CollaborationSpace>();
            PlayLists = new HashSet<PlayList>();
        }

        public int BandId { get; set; }
        public string BandName { get; set; }
        public string BandBio { get; set; }
        public string BandLogoUrl { get; set; }
        public string BandBackgroundImageUrl { get; set; }
        public string BandDisplayPhotoUrl { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ArtistBand> ArtistBands { get; set; }
        public virtual ICollection<BandGenre> BandGenres { get; set; }
        public virtual ICollection<CollaborationSpace> CollaborationSpaces { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
    }
}
