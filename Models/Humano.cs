
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReclutamientoGuillermoNassi.Models
{
    public class Humano
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public int Edad { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }  

    }
    

}
