
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReclutamientoGuillermoNassi.Models
{
    public class Humano
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;
        [MaxLength(30)]
        public string Sexo { get; set; } = null!;
        [Range(0,200)]
        public int Edad { get; set; }
        [Range(0,4)]
        public decimal Altura { get; set; }
        [Range(0, 700)]
        public decimal Peso { get; set; }  

    }
    

}
