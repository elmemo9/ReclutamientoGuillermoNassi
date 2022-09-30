using ReclutamientoGuillermoNassi.Models;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public class HumanoMockService : IHumanoMockService
    {

        public HumanoMockService()
        {

        }
        public HumanoResponse Get()
        {
            HumanoResponse humanoResponse = new();
            humanoResponse.Humanos = GetHumanos();
            return humanoResponse;
        }

        private List<Humano> GetHumanos() => new List<Humano>()
        {
            new Humano()
            {
                Id = 1,
                Nombre = "Juan Perez",
                Sexo = "Masculino",
                Edad = 25,
                Altura = (decimal)1.87,
                Peso = (decimal)78.7
            },
            new Humano()
            {
                Id = 2,
                Nombre = "Juana Ortega",
                Sexo = "Femenino",
                Edad = 22,
                Altura = (decimal)1.43,
                Peso = (decimal)54.2
            }
        };
    }
}
