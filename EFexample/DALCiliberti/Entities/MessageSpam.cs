using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class MessageSpam
    {
        public int MessageSpamId { get; set; }
        public int MessageId { get; set; }
        public int MessageBodyHash { get; set; }
    }
}
