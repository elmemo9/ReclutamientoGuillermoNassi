using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Services;

namespace ReclutamientoGuillermoNassi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        private readonly IHumanoService _humanoService;
        public HumanoController(IHumanoService humanoService)
        {
            _humanoService = humanoService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_humanoService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_humanoService.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest("Not Found!");
            }
        }
        [HttpPost]
        public IActionResult Add(HumanoRequest humanoRequest)
        {
            try
            {
                return Ok(_humanoService.Add(humanoRequest));
            }
            catch (Exception)
            {
                return BadRequest("Cannot be added");
            }
        }
        [HttpPut]
        public IActionResult Update(HumanoRequest humanoRequest)
        {
            try
            {
                return Ok(_humanoService.Update(humanoRequest));
            }
            catch (Exception)
            {
                return BadRequest("Cannot be updated!");
            }
        }
    }
}
