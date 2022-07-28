using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpaceMedium
    {
        public int CollaborationSpaceMediaId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int MediaId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Archive { get; set; }

        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual Medium Media { get; set; }
    }
}
