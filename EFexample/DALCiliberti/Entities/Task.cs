using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? DueDate { get; set; }
        public int? State { get; set; }
        public int? LinkType { get; set; }
        public int? LinkTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
