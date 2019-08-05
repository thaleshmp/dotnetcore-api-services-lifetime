using System;

namespace dotnetcore_api_services_lifetime.Services
{
    public class ScopedService : IScopedService
    {
        public Guid Id = Guid.NewGuid();

        public Guid GetGuid() => this.Id;
    }
}