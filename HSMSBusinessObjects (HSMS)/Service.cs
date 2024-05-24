using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = null!;
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int CategoryId { get; set; }

        public virtual ServiceRequest? ServiceRequest { get; set; }
    }
}
