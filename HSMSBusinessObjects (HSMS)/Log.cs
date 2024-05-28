using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Log
    {
        public int LogId { get; set; }
        public string Source { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime LDate { get; set; }
        public TimeSpan Time { get; set; }
        public string? Message { get; set; }
        public string OriginalValues { get; set; } = null!;
        public string CurrentValues { get; set; } = null!;

        public virtual AppUser User { get; set; } = null!;
    }
}
