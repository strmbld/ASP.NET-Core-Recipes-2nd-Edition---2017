using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpaceAlert
    {
        public int CollaborationSpaceAlertId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int ArtistId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
