using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mvc.Services
{
    public class EmailSenderOptions
    {
        public EmailSenderOptions()
        {
            EmailServerPort = 25;
            FromMailBoxName = "Admin Example";
            FromMailBoxAddress = "noreply@example.com";
        }


        public class AuthenticationSettings
        {
            public string EmailPassword { get; set; }

            public string EmailUserName { get; set; }
        }

        public AuthenticationSettings Authentication { get; set; }

        public string LocalDomain { get; set; }

        public string EmailServer { get; set; }

        public int EmailServerPort { get; set; }

        public string FromMailBoxName { get; set; }

        public string FromMailBoxAddress { get; set; }
    }
}
