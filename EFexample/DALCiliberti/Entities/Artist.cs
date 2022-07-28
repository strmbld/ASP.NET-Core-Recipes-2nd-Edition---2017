using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Artist
    {
        public Artist()
        {
            AlertSubscriptions = new HashSet<AlertSubscription>();
            ArtistBands = new HashSet<ArtistBand>();
            ArtistBlocks = new HashSet<ArtistBlock>();
            ArtistCollaborationSpaces = new HashSet<ArtistCollaborationSpace>();
            ArtistFavorites = new HashSet<ArtistFavorite>();
            ArtistSkills = new HashSet<ArtistSkill>();
            BandAuditionComments = new HashSet<BandAuditionComment>();
            BandAuditions = new HashSet<BandAudition>();
            CollaborationSpaceAlerts = new HashSet<CollaborationSpaceAlert>();
            CollaborationSpaceComments = new HashSet<CollaborationSpaceComment>();
            CollaborationSpaceInvites = new HashSet<CollaborationSpaceInvite>();
            Media = new HashSet<Medium>();
            MessageRecipients = new HashSet<MessageRecipient>();
            Messages = new HashSet<Message>();
            PlayLists = new HashSet<PlayList>();
            Tasks = new HashSet<Task>();
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRole>();
        }

        public int ArtistId { get; set; }
        public Guid? OldUserId { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string WebSite { get; set; }
        public byte ProfilePrivacyLevel { get; set; }
        public byte ContactPrivacyLevel { get; set; }
        public long ProfileViews { get; set; }
        public DateTime? ProfileLastViewDate { get; set; }
        public byte? Rating { get; set; }
        public string AvatarUrl { get; set; }
        public string EmailAddress { get; set; }
        public int FileUploadsInBytes { get; set; }
        public int FileUploadQuotaInBytes { get; set; }
        public DateTime LastActivityDate { get; set; }
        public bool? ShowChatStatus { get; set; }
        public bool? AllowChatSounds { get; set; }

        public virtual ArtistProfile ArtistProfile { get; set; }
        public virtual ICollection<AlertSubscription> AlertSubscriptions { get; set; }
        public virtual ICollection<ArtistBand> ArtistBands { get; set; }
        public virtual ICollection<ArtistBlock> ArtistBlocks { get; set; }
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; }
        public virtual ICollection<ArtistFavorite> ArtistFavorites { get; set; }
        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; }
        public virtual ICollection<BandAuditionComment> BandAuditionComments { get; set; }
        public virtual ICollection<BandAudition> BandAuditions { get; set; }
        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; }
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; }
        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; }
        public virtual ICollection<Medium> Media { get; set; }
        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<WebpagesUsersInRole> WebpagesUsersInRoles { get; set; }
    }
}
