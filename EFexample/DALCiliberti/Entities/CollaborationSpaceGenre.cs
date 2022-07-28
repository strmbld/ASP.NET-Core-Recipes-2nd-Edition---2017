using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpaceGenre
    {
        public int CollaborationSpaceGenreId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int GenreLookUpId { get; set; }

        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual GenreLookUp GenreLookUp { get; set; }
    }
}
