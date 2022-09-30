using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations;

namespace ReclutamientoGuillermoNassi.Requests
{
    public class HumanoRequest
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = null!;
        [Required, MaxLength(30)]
        public string Sexo { get; set; } = null!;
        [Required, Range(0, 200)]
        public int Edad { get; set; }
        [Required, Range(0, 4)]
        public decimal Altura { get; set; }
        [Required, Range(0, 700)]
        public decimal Peso { get; set; }

    }
}
