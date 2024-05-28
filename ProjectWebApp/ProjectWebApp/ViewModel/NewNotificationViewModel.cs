#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewNotificationViewModel
    {
        public Notification notification { get; set; }
        
        public string? SearchString;

        public virtual AppUser User { get; set; }
        public DateTime? NDate { get; set; }

        public IEnumerable<Notification> Notifications { get; set; }
    }
}
