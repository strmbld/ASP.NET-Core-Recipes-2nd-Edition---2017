using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class EmailVerification
    {
        public int EmailVerificationId { get; set; }
        public int ArtistId { get; set; }
        public string Emailaddress { get; set; }
        public string VerificationCode { get; set; }
        public DateTime NotificationSendDate { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}
