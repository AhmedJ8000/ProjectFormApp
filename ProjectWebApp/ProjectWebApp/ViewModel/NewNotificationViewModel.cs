#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewNotificationViewModel
    {
        public Notification notification { get; set; }

        public string? SearchString;

        public IEnumerable<Notification> Notifications { get; set; }
    }
}
