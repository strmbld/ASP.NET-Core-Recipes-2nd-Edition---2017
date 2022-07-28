using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Message
    {
        public Message()
        {
            MessageRecipients = new HashSet<MessageRecipient>();
        }

        public int MessageId { get; set; }
        public int ArtistId { get; set; }
        public string Subject { get; set; }
        public short Importance { get; set; }
        public DateTime DateSent { get; set; }
        public string MessageBody { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; }
    }
}
