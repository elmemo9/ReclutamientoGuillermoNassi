using ReclutamientoGuillermoNassi.Models;
using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public class HumanoService : IHumanoService
    {
        private readonly HumanidadContext _humanidadContext;
        public HumanoService (HumanidadContext humanidadContext)
        {
            _humanidadContext = humanidadContext;
        }
        public HumanoResponse Add(HumanoRequest humanoRequest)
        {

            using (var transaction = _humanidadContext.Database.BeginTransaction())
            {

                try
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
                    _humanidadContext.Humanos.Add(humano);
                    _humanidadContext.SaveChanges();
                    humanoResponse.Humanos.Add(humano);
                transaction.Commit();
                return humanoResponse;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            }

        }

        public HumanoResponse Get()
        {
            HumanoResponse humanoResponse = new HumanoResponse();
            humanoResponse.Humanos = _humanidadContext.Humanos.ToList();
            return humanoResponse;
        }

        public HumanoResponse GetById(int id)
        {
            HumanoResponse humanoResponse = new HumanoResponse();
            Humano? humano = _humanidadContext.Humanos.Find(id);
            if (humano == null) throw new NullReferenceException();
            humanoResponse.Humanos.Add(humano);
            return humanoResponse;
        }

        public HumanoResponse Update(HumanoRequest humanoRequest)
        {
            using (var transaction = _humanidadContext.Database.BeginTransaction())
            {

                try
                {
                    HumanoResponse humanoResponse = new HumanoResponse();
                    Humano? humano = _humanidadContext.Humanos.Find(humanoRequest.Id);
                    if (humano == null) throw new NullReferenceException(); 

                        humano.Nombre = humanoRequest.Nombre;
                        humano.Sexo = humanoRequest.Sexo;
                        humano.Edad = humanoRequest.Edad;
                        humano.Altura = humanoRequest.Altura;
                        humano.Peso = humanoRequest.Peso;

                    
                    _humanidadContext.Humanos.Update(humano);
                    _humanidadContext.SaveChanges();
                    humanoResponse.Humanos.Add(humano);
                    transaction.Commit();
                    return humanoResponse;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
