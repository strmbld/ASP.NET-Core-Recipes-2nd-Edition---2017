using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class SongComment
    {
        public int SongCommentId { get; set; }
        public int? SongId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAnonymous { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual Song Song { get; set; }
    }
}
