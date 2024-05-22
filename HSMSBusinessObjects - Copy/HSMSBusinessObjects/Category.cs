using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public string? ManagerId { get; set; }

        public virtual AspNetUser Manager { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
