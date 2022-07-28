using System;
using System.Collections.Generic;

#nullable disable

namespace DALCiliberti.Entities
{
    public partial class WebpagesRole
    {
        public WebpagesRole()
        {
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid? OldRoleId { get; set; }

        public virtual ICollection<WebpagesUsersInRole> WebpagesUsersInRoles { get; set; }
    }
}
