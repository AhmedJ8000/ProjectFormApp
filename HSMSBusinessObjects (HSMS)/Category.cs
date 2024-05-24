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
        public int ManagerId { get; set; }

        public virtual User Manager { get; set; } = null!;
        public virtual ICollection<Service> Services { get; set; }
    }
}
