using System;

namespace dotnetcore_api_services_lifetime.Services
{
    public interface IScopedService
    {
        Guid GetGuid();
    }
}