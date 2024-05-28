#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewCategoryViewModel
    {
        public Category category { get; set; }

        public string? SearchString;

        public virtual IEnumerable<Category> Categories { get; set; }
        public virtual IEnumerable<AppUser> Users { get; set; }
    }
}
