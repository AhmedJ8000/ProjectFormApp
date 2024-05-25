using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class ServiceRequest
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DateNeeded { get; set; }
        public double Price { get; set; }
        public int? CommentId { get; set; }
        public string TechnicianId { get; set; } = null!;
        public bool? IsPending { get; set; }

        public virtual Comment? Comment { get; set; }
        public virtual Service IdNavigation { get; set; } = null!;
        public virtual AppUser Technician { get; set; } = null!;
    }
}
