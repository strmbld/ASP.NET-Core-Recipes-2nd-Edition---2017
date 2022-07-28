using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class GenreLookUp
    {
        public GenreLookUp()
        {
            BandGenres = new HashSet<BandGenre>();
            CollaborationSpaceGenres = new HashSet<CollaborationSpaceGenre>();
        }

        public int GenreLookUpId { get; set; }
        public string GenreName { get; set; }
        public string Culture { get; set; }

        public virtual ICollection<BandGenre> BandGenres { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
    }
}
