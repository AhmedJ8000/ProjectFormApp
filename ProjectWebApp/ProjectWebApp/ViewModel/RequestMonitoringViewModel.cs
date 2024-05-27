namespace ProjectWebApp.ViewModel
{
    public class RequestMonitoringViewModel
    {
        public string CategoryName { get; set; }
        public int TotalRequests { get; set; }
        public int PendingRequests { get; set; }
        public int OverdueRequests { get; set; }
    }
}
