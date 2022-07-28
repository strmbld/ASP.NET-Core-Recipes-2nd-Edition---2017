using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DALCiliberti.Entities;

#nullable disable

namespace DALCiliberti.Context
{
    public partial class Mvc6RecipesSharedDbContext : DbContext
    {
        public Mvc6RecipesSharedDbContext()
        {
        }

        public Mvc6RecipesSharedDbContext(DbContextOptions<Mvc6RecipesSharedDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AlertSubscription> AlertSubscriptions { get; set; }
        public virtual DbSet<AlertTag> AlertTags { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistBand> ArtistBands { get; set; }
        public virtual DbSet<ArtistBlock> ArtistBlocks { get; set; }
        public virtual DbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public virtual DbSet<ArtistFavorite> ArtistFavorites { get; set; }
        public virtual DbSet<ArtistProfile> ArtistProfiles { get; set; }
        public virtual DbSet<ArtistSkill> ArtistSkills { get; set; }
        public virtual DbSet<Band> Bands { get; set; }
        public virtual DbSet<BandAudition> BandAuditions { get; set; }
        public virtual DbSet<BandAuditionComment> BandAuditionComments { get; set; }
        public virtual DbSet<BandGenre> BandGenres { get; set; }
        public virtual DbSet<BannedEmailAddress> BannedEmailAddresses { get; set; }
        public virtual DbSet<CollaborationSpace> CollaborationSpaces { get; set; }
        public virtual DbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public virtual DbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual DbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public virtual DbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
        public virtual DbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public virtual DbSet<CollaborationSpaceMedium> CollaborationSpaceMedia { get; set; }
        public virtual DbSet<EmailOptOut> EmailOptOuts { get; set; }
        public virtual DbSet<EmailVerification> EmailVerifications { get; set; }
        public virtual DbSet<GenreLookUp> GenreLookUps { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageRecipient> MessageRecipients { get; set; }
        public virtual DbSet<MessageSpam> MessageSpams { get; set; }
        public virtual DbSet<OpenPosition> OpenPositions { get; set; }
        public virtual DbSet<PlayList> PlayLists { get; set; }
        public virtual DbSet<PlaylistItem> PlaylistItems { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongComment> SongComments { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<WebpagesMembership> WebpagesMemberships { get; set; }
        public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMemberships { get; set; }
        public virtual DbSet<WebpagesRole> WebpagesRoles { get; set; }
        public virtual DbSet<WebpagesUsersInRole> WebpagesUsersInRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.,5433;Database=Mvc6RecipesSharedDb;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("Alert");

                entity.Property(e => e.ActorAvatarUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActorDisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActorUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AlertAddedDate).HasColumnType("datetime");

                entity.Property(e => e.AlertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AlertUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Headline)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemIdentifier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertSubscription>(entity =>
            {
                entity.ToTable("AlertSubscription");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.AlertSubscriptions)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertSubscription_Artist");
            });

            modelBuilder.Entity<AlertTag>(entity =>
            {
                entity.ToTable("AlertTag");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.AlertTags)
                    .HasForeignKey(d => d.AlertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlertTag_Alert");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist");

                entity.Property(e => e.AllowChatSounds)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AvatarUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("AvatarURL");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.LastActivityDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileLastViewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Province)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).HasDefaultValueSql("((3))");

                entity.Property(e => e.ShowChatStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtistBand>(entity =>
            {
                entity.ToTable("ArtistBand");

                entity.Property(e => e.DeactivateDate).HasColumnType("datetime");

                entity.Property(e => e.IsActiveMember)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinedDate).HasColumnType("datetime");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistBands)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistBand_ToArtist");

                entity.HasOne(d => d.Band)
                    .WithMany(p => p.ArtistBands)
                    .HasForeignKey(d => d.BandId)
                    .HasConstraintName("FK_ArtistBand_ToBand");
            });

            modelBuilder.Entity<ArtistBlock>(entity =>
            {
                entity.ToTable("ArtistBlock");

                entity.Property(e => e.ArtistBlockId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistBlocks)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistBlock_Artist");
            });

            modelBuilder.Entity<ArtistCollaborationSpace>(entity =>
            {
                entity.ToTable("ArtistCollaborationSpace");

                entity.Property(e => e.FirstContributionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastContributionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistCollaborationSpaces)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistCollaborationSpaces_ToTable");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.ArtistCollaborationSpaces)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistCollaborationSpaces_ToTable_1");
            });

            modelBuilder.Entity<ArtistFavorite>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistFavorites)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistFavorites_Artist");
            });

            modelBuilder.Entity<ArtistProfile>(entity =>
            {
                entity.HasKey(e => e.ArtistId)
                    .HasName("PK__ArtistPr__25706B50909422BB");

                entity.ToTable("ArtistProfile");

                entity.Property(e => e.ArtistId).ValueGeneratedNever();

                entity.Property(e => e.Bio).IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MusicalInfluences)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileTemplateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('basic')");

                entity.HasOne(d => d.Artist)
                    .WithOne(p => p.ArtistProfile)
                    .HasForeignKey<ArtistProfile>(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistProfile_Artist");
            });

            modelBuilder.Entity<ArtistSkill>(entity =>
            {
                entity.HasKey(e => e.ArtistTalentId)
                    .HasName("PK__tmp_ms_x__A9AD4EAAFEE755FA");

                entity.ToTable("ArtistSkill");

                entity.Property(e => e.ArtistTalentId).HasColumnName("ArtistTalentID");

                entity.Property(e => e.Details)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SkillLevel).HasDefaultValueSql("((3))");

                entity.Property(e => e.Styles)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TalentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistSkills)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArtistSkill_Artist");
            });

            modelBuilder.Entity<Band>(entity =>
            {
                entity.ToTable("Band");

                entity.Property(e => e.BandBackgroundImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BandBio)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BandDisplayPhotoUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BandLogoUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BandAudition>(entity =>
            {
                entity.ToTable("BandAudition");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.BandAuditions)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandAudition_Artist");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.BandAuditions)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandAudition_Song");
            });

            modelBuilder.Entity<BandAuditionComment>(entity =>
            {
                entity.ToTable("BandAuditionComment");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.BandAuditionComments)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandAuditionComment_Artist");

                entity.HasOne(d => d.BandAudition)
                    .WithMany(p => p.BandAuditionComments)
                    .HasForeignKey(d => d.BandAuditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandAuditionComment_BandAudition");
            });

            modelBuilder.Entity<BandGenre>(entity =>
            {
                entity.ToTable("BandGenre");

                entity.HasOne(d => d.Band)
                    .WithMany(p => p.BandGenres)
                    .HasForeignKey(d => d.BandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandGenre_Band");

                entity.HasOne(d => d.GenreLookUp)
                    .WithMany(p => p.BandGenres)
                    .HasForeignKey(d => d.GenreLookUpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BandGenre_GenreLookUp");
            });

            modelBuilder.Entity<BannedEmailAddress>(entity =>
            {
                entity.HasKey(e => e.EmailAddress)
                    .HasName("PK__BannedEm__49A147411D4025E8");

                entity.ToTable("BannedEmailAddress");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CollaborationSpace>(entity =>
            {
                entity.ToTable("CollaborationSpace");

                entity.Property(e => e.AllowPublicView)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConceptMediaType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.LastPostDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Band)
                    .WithMany(p => p.CollaborationSpaces)
                    .HasForeignKey(d => d.BandId)
                    .HasConstraintName("FK_CollaborationSpace_ToTable");
            });

            modelBuilder.Entity<CollaborationSpaceAlert>(entity =>
            {
                entity.Property(e => e.CollaborationSpaceAlertId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.CollaborationSpaceAlerts)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceAlerts_Artist");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceAlerts)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceAlerts_CollaborationSpace");
            });

            modelBuilder.Entity<CollaborationSpaceComment>(entity =>
            {
                entity.ToTable("CollaborationSpaceComment");

                entity.Property(e => e.CollaborationSpaceId).HasColumnName("CollaborationSpaceID");

                entity.Property(e => e.CommentBody)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('/')");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.CollaborationSpaceComments)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceComment_Artist");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceComments)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceComment_CollaborationSpace");

                entity.HasOne(d => d.CollabortationSpaceFile)
                    .WithMany(p => p.CollaborationSpaceComments)
                    .HasForeignKey(d => d.CollabortationSpaceFileId)
                    .HasConstraintName("FK_CollaborationSpaceComment_ToTable");
            });

            modelBuilder.Entity<CollaborationSpaceFile>(entity =>
            {
                entity.ToTable("CollaborationSpaceFile");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceFiles)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceFile_CollaborationSpace");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.CollaborationSpaceFiles)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceFile_Media");
            });

            modelBuilder.Entity<CollaborationSpaceGenre>(entity =>
            {
                entity.ToTable("CollaborationSpaceGenre");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceGenres)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceGenre_CollaborationSpace");

                entity.HasOne(d => d.GenreLookUp)
                    .WithMany(p => p.CollaborationSpaceGenres)
                    .HasForeignKey(d => d.GenreLookUpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceGenre_GenreLookUp");
            });

            modelBuilder.Entity<CollaborationSpaceInvite>(entity =>
            {
                entity.ToTable("CollaborationSpaceInvite");

                entity.Property(e => e.CollaborationSpaceInviteId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.CollaborationSpaceInvites)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceInvite_Artist");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceInvites)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceInvite_CollaborationSpace");
            });

            modelBuilder.Entity<CollaborationSpaceMedium>(entity =>
            {
                entity.HasKey(e => e.CollaborationSpaceMediaId)
                    .HasName("PK__tmp_ms_x__6E7080F6EBAB47DC");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.CollaborationSpaceMedia)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceMedia_CollaborationSpace");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.CollaborationSpaceMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborationSpaceMedia_ToTable_1");
            });

            modelBuilder.Entity<EmailOptOut>(entity =>
            {
                entity.HasKey(e => e.EmailAddress)
                    .HasName("PK__EmailOpt__49A14741BB5BF2C0");

                entity.ToTable("EmailOptOut");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfOptOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailVerification>(entity =>
            {
                entity.ToTable("EmailVerification");

                entity.Property(e => e.Emailaddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.NotificationSendDate).HasColumnType("datetime");

                entity.Property(e => e.VerificationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerificationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenreLookUp>(entity =>
            {
                entity.ToTable("GenreLookUp");

                entity.Property(e => e.Culture)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('en')");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PK__tmp_ms_x__B2C2B5CFA6A43414");

                entity.Property(e => e.AzureBlobReferenceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AzureStorageContainer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileExtention)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyFileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ripemd160hash)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RIPEMD160Hash");

                entity.Property(e => e.WebUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("WebURL");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Media_ToTable");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.Property(e => e.DateSent).HasColumnType("smalldatetime");

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Artist");
            });

            modelBuilder.Entity<MessageRecipient>(entity =>
            {
                entity.ToTable("MessageRecipient");

                entity.Property(e => e.Folder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.MessageRecipients)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageRecipient_Artist");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageRecipients)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageRecipient_Message");
            });

            modelBuilder.Entity<MessageSpam>(entity =>
            {
                entity.ToTable("MessageSpam");

                entity.Property(e => e.MessageSpamId).HasColumnName("MessageSpamID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");
            });

            modelBuilder.Entity<OpenPosition>(entity =>
            {
                entity.ToTable("OpenPosition");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatePosted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LocalCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalProvence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Talent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CollaborationSpace)
                    .WithMany(p => p.OpenPositions)
                    .HasForeignKey(d => d.CollaborationSpaceId)
                    .HasConstraintName("FK_OpenPosition_CollaborationSpace");
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.ToTable("PlayList");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.PlayLists)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Playlist_Artist");

                entity.HasOne(d => d.Band)
                    .WithMany(p => p.PlayLists)
                    .HasForeignKey(d => d.BandId)
                    .HasConstraintName("FK_PlayList_Band");
            });

            modelBuilder.Entity<PlaylistItem>(entity =>
            {
                entity.ToTable("PlaylistItem");

                entity.HasOne(d => d.PlayList)
                    .WithMany(p => p.PlaylistItems)
                    .HasForeignKey(d => d.PlayListId)
                    .HasConstraintName("FK_PlaylistItem_PayList");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.PlaylistItems)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaylistItem_Song");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("Song");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionParameter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArtworkUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ArtworkURL");

                entity.Property(e => e.Controller)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GenreId).HasDefaultValueSql("((21))");

                entity.Property(e => e.Lyrics)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ShowInLibrary)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SongDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SongTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Song_Media");
            });

            modelBuilder.Entity<SongComment>(entity =>
            {
                entity.ToTable("SongComment");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongComments)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("FK_SongComment_Song");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.LinkTypeId).HasColumnName("LinkTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Artist");
            });

            modelBuilder.Entity<WebpagesMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__webpages__1788CC4CFDFEEF30");

                entity.ToTable("webpages_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesOauthMembership>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ProviderUserId })
                    .HasName("PK__webpages__F53FC0EDBCE1C3BB");

                entity.ToTable("webpages_OAuthMembership");

                entity.Property(e => e.Provider).HasMaxLength(30);

                entity.Property(e => e.ProviderUserId).HasMaxLength(100);
            });

            modelBuilder.Entity<WebpagesRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__webpages__8AFACE1A7703E1A6");

                entity.ToTable("webpages_Roles");

                entity.HasIndex(e => e.RoleName, "UQ__webpages__8A2B6160848C0403")
                    .IsUnique();

                entity.Property(e => e.OldRoleId).HasColumnName("OldRoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<WebpagesUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__webpages__AF2760ADA034EF37");

                entity.ToTable("webpages_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
