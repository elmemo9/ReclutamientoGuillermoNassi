
using System.ComponentModel.DataAnnotations;

namespace ReclutamientoGuillermoNassi.Requests
{
    public class OperacionRequest
    {
        [Required]
        public decimal A { get; set; }
        [Required]
        public decimal B { get; set; }
        [Required]
        public string Operacion { get; set; } = null!;

    }
}
