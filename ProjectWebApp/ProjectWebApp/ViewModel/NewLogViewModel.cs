#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewLogViewModel
    {
        public Log log { get; set; }

        public IEnumerable<Log> Logs { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
