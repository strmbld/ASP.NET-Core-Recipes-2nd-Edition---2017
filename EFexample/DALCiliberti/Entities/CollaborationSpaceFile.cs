using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpaceFile
    {
        public CollaborationSpaceFile()
        {
            CollaborationSpaceComments = new HashSet<CollaborationSpaceComment>();
        }

        public int CollaborationSpaceFileId { get; set; }
        public int CollaborationSpaceId { get; set; }
        public int MediaId { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }

        public virtual CollaborationSpace CollaborationSpace { get; set; }
        public virtual Medium Media { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
    }
}
