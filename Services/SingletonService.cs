using System;

namespace dotnetcore_api_services_lifetime.Services
{
    public class SingletonService : ISingletonService
    {
        public Guid Id = Guid.NewGuid();
        public Guid GetGuid() => this.Id;
    }
}