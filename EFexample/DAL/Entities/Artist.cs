using System;
using System.Collections.Generic;


namespace DAL.Entities
{
    public class Artist
    {
        public int Id { get; set; } // conventional: EF looks for Id or ArtistId to create PK

        public string Name { get; set; }

        public string Country { get; set; }

        public string Provence { get; set; }

        public string City { get; set; }

        public string WebSite { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public virtual IList<ArtistSkill> ArtistSkills { get; set; } // conventional: virtual;
                                                                     // EF will use this signature to create navigation property
                                                                     // representing relation (OneToMany here)
    }
}
