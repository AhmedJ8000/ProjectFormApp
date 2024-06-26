﻿using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public string Message { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime? NDate { get; set; }

        public virtual AppUser User { get; set; } = null!;
    }
}
