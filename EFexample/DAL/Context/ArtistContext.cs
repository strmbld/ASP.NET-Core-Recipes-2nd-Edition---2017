using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace DAL.Context
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options) { }


        public DbSet<Artist>? Artists { get; set; }

        public DbSet<ArtistSkill>? ArtistsSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Artist
            builder.Entity<Artist>().Property(a => a.City).HasMaxLength(50);
            builder.Entity<Artist>().Property(a => a.Country).HasMaxLength(50);
            builder.Entity<Artist>().Property(a => a.Provence).HasMaxLength(50);
            builder.Entity<Artist>().Property(a => a.Name).HasMaxLength(50).HasColumnName("UserName").IsRequired(true);
            builder.Entity<Artist>().Property(a => a.WebSite).HasMaxLength(255);
            builder.Entity<Artist>().Property(a => a.CreatedAt).HasColumnName("CreateDate");
            builder.Entity<Artist>().Property(a => a.Id).HasColumnName("ArtistId");

            // ArtistSkill
            builder.Entity<ArtistSkill>().Property(s => s.Details).HasMaxLength(255);
            builder.Entity<ArtistSkill>().Property(s => s.Name).HasMaxLength(50).HasColumnName("TalentName").IsRequired(true);
            builder.Entity<ArtistSkill>().Property(s => s.Styles).HasMaxLength(255);
            builder.Entity<ArtistSkill>().Property(s => s.Id).HasColumnName("ArtistSkillId");
        }
    }
}
