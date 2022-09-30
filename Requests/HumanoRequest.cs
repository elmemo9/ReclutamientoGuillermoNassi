using System.ComponentModel.DataAnnotations;

namespace ReclutamientoGuillermoNassi.Requests
{
    public class HumanoRequest
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string Sexo { get; set; } = null!;
        [Required]
        public int Edad { get; set; }
        [Required]
        public decimal Altura { get; set; }
        [Required]
        public decimal Peso { get; set; }

    }
}
