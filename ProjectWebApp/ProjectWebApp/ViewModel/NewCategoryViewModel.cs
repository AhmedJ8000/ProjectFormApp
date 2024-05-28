#nullable disable
using HSMSBusinessObjects;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebApp.ViewModel
{
    public class NewCategoryViewModel
    {
        public Category category { get; set; }

        public string? SearchString;

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
