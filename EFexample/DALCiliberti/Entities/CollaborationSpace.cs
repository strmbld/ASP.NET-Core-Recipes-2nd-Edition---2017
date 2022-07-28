using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class CollaborationSpace
    {
        public CollaborationSpace()
        {
            ArtistCollaborationSpaces = new HashSet<ArtistCollaborationSpace>();
            CollaborationSpaceAlerts = new HashSet<CollaborationSpaceAlert>();
            CollaborationSpaceComments = new HashSet<CollaborationSpaceComment>();
            CollaborationSpaceFiles = new HashSet<CollaborationSpaceFile>();
            CollaborationSpaceGenres = new HashSet<CollaborationSpaceGenre>();
            CollaborationSpaceInvites = new HashSet<CollaborationSpaceInvite>();
            CollaborationSpaceMedia = new HashSet<CollaborationSpaceMedium>();
            OpenPositions = new HashSet<OpenPosition>();
        }

        public int CollaborationSpaceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool RestrictContributorsToBand { get; set; }
        public int? BandId { get; set; }
        public bool? AllowPublicView { get; set; }
        public byte CopyrightModel { get; set; }
        public bool AllowContributorsToPublish { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? LastPostDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int NumberViews { get; set; }
        public int NumberComments { get; set; }
        public byte Status { get; set; }
        public int? ConceptId { get; set; }
        public string ConceptMediaType { get; set; }

        public virtual Band Band { get; set; }
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public virtual ICollection<CollaborationSpaceMedium> CollaborationSpaceMedia { get; set; }
        public virtual ICollection<OpenPosition> OpenPositions { get; set; }
    }
}
