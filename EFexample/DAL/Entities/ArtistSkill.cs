using System;


namespace DAL.Entities
{
    public class ArtistSkill
    {
        public int Id { get; set; } // conventional: EF looks for Id or ArtistSkillId to create PK

        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public string Details { get; set; }

        public string Styles { get; set; }

        public virtual Artist Artist { get; set; } // conventional: virtual;
                                                   // EF will use this signature to create navigation property (another side here)
                                                   // representing relation (ManyToOne here)
    }
}
