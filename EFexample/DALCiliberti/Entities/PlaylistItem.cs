using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class PlaylistItem
    {
        public int PlaylistItemId { get; set; }
        public int PlayListId { get; set; }
        public int SongId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual PlayList PlayList { get; set; }
        public virtual Song Song { get; set; }
    }
}
