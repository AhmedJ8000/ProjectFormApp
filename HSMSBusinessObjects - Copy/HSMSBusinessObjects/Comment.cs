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
        public int UserId { get; set; }

        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
