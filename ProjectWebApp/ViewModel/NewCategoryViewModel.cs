using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewCategoryViewModel
    {
        public Category category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<AspNetUser> Users { get; set; }
    }
}
