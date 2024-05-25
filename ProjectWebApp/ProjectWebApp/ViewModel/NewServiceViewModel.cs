#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewServiceViewModel
    {
        public Service service { get; set; }

        public string? SearchString;
        public string? SearchCategory;

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
