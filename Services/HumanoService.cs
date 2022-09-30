using ReclutamientoGuillermoNassi.Models;
using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public class HumanoService : IHumanoService
    {
        public HumanoResponse Add(HumanoRequest humanoRequest)
        {
            HumanoResponse humanoResponse = new HumanoResponse();
            Humano humano = new Humano()
            {
                Nombre = humanoRequest.Nombre,
                Sexo = humanoRequest.Sexo,
                Edad = humanoRequest.Edad,
                Altura = humanoRequest.Altura,
                Peso = humanoRequest.Peso
                
            };
        }

        public List<HumanoResponse> Get()
        {
            throw new NotImplementedException();
        }

        public HumanoResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public HumanoResponse Update(HumanoRequest humanoRequest)
        {
            throw new NotImplementedException();
        }
    }
}
