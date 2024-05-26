using HSMSBusinessObjects;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp.Controllers
{
    public class MonitoringController : Controller
    {
        private readonly HSMSContext _context;

        public MonitoringController()
        {
            _context = new HSMSContext();
        }

        public IActionResult Index()
        {
            var totalRequests = GetTotalRequestCount();
            var pendingRequests = GetPendingRequestCount();
            var overdueRequests = GetOverdueRequestCount();

            var viewModel = new RequestMonitoringViewModel
            {
                TotalRequests = totalRequests,
                PendingRequests = pendingRequests,
                OverdueRequests = overdueRequests
            };

            return View(viewModel);
        }

        private int GetTotalRequestCount()
        {
            //return _context.ServiceRequests;
        }

        private int GetPendingRequestCount()
        {
            return 0;
        }

        private int GetOverdueRequestCount()
        {
            return 0;
        }
    }
}
