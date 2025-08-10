using System.Threading.Tasks;
using dotnet5.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaticSiteController : ControllerBase
    {
        private readonly StaticSiteProvisioningService _service;

        public StaticSiteController(StaticSiteProvisioningService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<StaticSiteResponse>> Create(StaticSiteRequest request)
        {
            var url = await _service.ProvisionStaticSiteAsync(request);
            return Ok(new StaticSiteResponse { Url = url });
        }
    }
}
