using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReclutamientoGuillermoNassi.Responses;
using ReclutamientoGuillermoNassi.Services;

namespace ReclutamientoGuillermoNassi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoMockController : ControllerBase
    {
        private readonly IHumanoMockService _humanoMockService;
        public HumanoMockController(IHumanoMockService humanoMockService)
        {
            _humanoMockService = humanoMockService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            HumanoResponse humanoResponse = _humanoMockService.Get();
            return Ok(humanoResponse);
        }
    }
}
