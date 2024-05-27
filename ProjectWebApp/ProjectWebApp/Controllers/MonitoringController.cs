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

        public IActionResult Index(int? catId)
        {
            var totalRequests = GetTotalRequestCount(catId);
            var pendingRequests = GetPendingRequestCount(catId);
            var overdueRequests = GetOverdueRequestCount(catId);

            var viewModel = new RequestMonitoringViewModel
            {
                TotalRequests = totalRequests,
                PendingRequests = pendingRequests,
                OverdueRequests = overdueRequests
            };

            return View(viewModel);
        }

        private int GetTotalRequestCount(int? catId)
        {
            return _context.ServiceRequests.Where(x => x.IdNavigation.CategoryId == catId).Count();
        }

        private int GetPendingRequestCount(int? catId)
        {
            return 0;
        }

        private int GetOverdueRequestCount(int? catId)
        {
            return 0;
        }
    }
}
