using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpaceInvite
    {
        public int CollaborationSpaceInviteId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public string EmailAddress { get; set; }
        public int ArtistId { get; set; }
        public int? BandId { get; set; }
        public Guid LinkIdentifier { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
