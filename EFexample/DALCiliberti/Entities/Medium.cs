using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class Medium
    {
        public Medium()
        {
            CollaborationSpaceFiles = new HashSet<CollaborationSpaceFile>();
            CollaborationSpaceMedia = new HashSet<CollaborationSpaceMedium>();
            Songs = new HashSet<Song>();
        }

        public int MediaId { get; set; }
        public int? ArtistId { get; set; }
        public string FriendlyFileName { get; set; }
        public string FileExtention { get; set; }
        public string LocalFilePath { get; set; }
        public string WebUrl { get; set; }
        public bool IsCloudBlob { get; set; }
        public string AzureStorageContainer { get; set; }
        public string AzureBlobReferenceName { get; set; }
        public byte MediaType { get; set; }
        public int FileSizeInBytes { get; set; }
        public int BitRateInKbps { get; set; }
        public int AllowDownload { get; set; }
        public int DownloadCount { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFileDeleted { get; set; }
        public string Ripemd160hash { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; }
        public virtual ICollection<CollaborationSpaceMedium> CollaborationSpaceMedia { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
