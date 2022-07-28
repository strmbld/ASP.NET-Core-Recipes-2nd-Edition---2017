using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class OpenPosition
    {
        public int OpenPositionId { get; set; }
        public int? CollaborationSpaceId { get; set; }
        public string Talent { get; set; }
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateModified { get; set; }
        public int Status { get; set; }
        public int? BandId { get; set; }
        public bool LocalOnly { get; set; }
        public string LocalCity { get; set; }
        public string LocalCountry { get; set; }
        public string LocalProvence { get; set; }
        public int AuditionsSubmitted { get; set; }
        public int ApprovalMode { get; set; }

        public virtual CollaborationSpace CollaborationSpace { get; set; }
    }
}
