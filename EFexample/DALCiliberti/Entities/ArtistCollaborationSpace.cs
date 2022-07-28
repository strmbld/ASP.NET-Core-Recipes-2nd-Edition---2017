using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class ArtistCollaborationSpace
    {
        public int ArtistCollaborationSpaceId { get; set; }
        public int ArtistId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public bool IsCreator { get; set; }
        public DateTime FirstContributionDate { get; set; }
        public DateTime LastContributionDate { get; set; }
        public string Note { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
