using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore_api_services_lifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_api_services_lifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;

        public ValuesController(IScopedService scopedService, ITransientService transientService, ISingletonService singletonService)
        {
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService = singletonService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var scopedGuid = (HttpContext.RequestServices.GetService(typeof(IScopedService)) as IScopedService).GetGuid();
            var transientGuid = (HttpContext.RequestServices.GetService(typeof(ITransientService)) as ITransientService).GetGuid();
            var singletonGuid = (HttpContext.RequestServices.GetService(typeof(ISingletonService)) as ISingletonService).GetGuid();

            return View("~/Views/Index.cshtml", new string[] {
                $"IOC Scoped Id: {_scopedService.GetGuid()}",
                $"IOC Transient Id: {_transientService.GetGuid()}",
                $"IOC Singleton Id: {_singletonService.GetGuid()}",
                $"SVCLocator Scoped Id: {scopedGuid}",
                $"SVCLocator Transient Id: {transientGuid}",
                $"SVCLocator Singleton Id: {singletonGuid}"
            });
        }
    }
}
