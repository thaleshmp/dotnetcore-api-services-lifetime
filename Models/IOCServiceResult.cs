namespace dotnetcore_api_services_lifetime.Models
{
    public class IOCServiceResult
    {
        public IOCServiceResult(string lifetimeType, string svcLocatorValue, string iocValue)
        {
            this.LifetimeType = lifetimeType;
            this.SVCLocatorValue = svcLocatorValue;
            this.IOCValue = iocValue;
        }

        public string LifetimeType { get; set; }
        public string SVCLocatorValue { get; set; }
        public string IOCValue { get; set; }
    }
}