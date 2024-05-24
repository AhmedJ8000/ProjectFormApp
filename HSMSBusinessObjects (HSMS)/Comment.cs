using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Comment
    {
        public Comment()
        {
            ServiceRequests = new HashSet<ServiceRequest>();
        }

        public int CommentId { get; set; }
        public string? Notes { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string UserId { get; set; } = null!;

        public virtual AppUser User { get; set; } = null!;
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
