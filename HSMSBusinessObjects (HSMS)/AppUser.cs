using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class AppUser
    {
        public AppUser()
        {
            Categories = new HashSet<Category>();
            Comments = new HashSet<Comment>();
            Documents = new HashSet<Document>();
            Logs = new HashSet<Log>();
        }

        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string Email { get; set; } = null!;
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
