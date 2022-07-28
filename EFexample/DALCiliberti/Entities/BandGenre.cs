using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class BandGenre
    {
        public int BandGenreId { get; set; }
        public int BandId { get; set; }
        public int GenreLookUpId { get; set; }

        public virtual Band Band { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
