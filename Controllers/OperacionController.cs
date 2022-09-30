using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;
using ReclutamientoGuillermoNassi.Services;

namespace ReclutamientoGuillermoNassi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionController : ControllerBase
    {
        private readonly IOperacionService _operacionService;
        public OperacionController(IOperacionService operacionService)
        {
            _operacionService = operacionService;
        }
        [HttpPost]
        public IActionResult OperacionPost(OperacionRequest operacionRequest)
        {
            try
            {
                OperacionResponse operacionResponse = _operacionService.Operacion(operacionRequest);
                return Ok(operacionResponse);
            }
            catch (Exception)
            {
                return BadRequest("Valores no válidos");
            }
            
        }
        [HttpGet]
        public IActionResult OperacionGet([FromHeader] int A, [FromHeader] int B, [FromHeader] string Operacion) 
        {
            try
            {
                OperacionRequest operacionRequest = new()
                {
                    A = A,
                    B = B,
                    Operacion = Operacion
                };
                OperacionResponse operacionResponse = _operacionService.Operacion(operacionRequest);
                return Ok(operacionResponse);
            }
            catch (Exception)
            {
                return BadRequest("Valores no válidos");
            }

           
        }
    }
}
