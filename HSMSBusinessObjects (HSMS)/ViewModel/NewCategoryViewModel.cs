using HSMSBusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebApp.ViewModel
{
    public class NewCategoryViewModel
    {
        public Category category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
