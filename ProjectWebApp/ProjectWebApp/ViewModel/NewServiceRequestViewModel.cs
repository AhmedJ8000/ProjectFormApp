#nullable disable
using HSMSBusinessObjects;

namespace ProjectWebApp.ViewModel
{
    public class NewServiceRequestViewModel
    {
        public ServiceRequest serviceRequest { get; set; }
        public Service service { get; set; }

        public string? SearchString;

        public IEnumerable<ServiceRequest> ServiceRequests { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
