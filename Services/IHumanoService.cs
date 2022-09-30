using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public interface IHumanoService
    {
        public HumanoResponse Get();
        public HumanoResponse GetById(int id);
        public HumanoResponse Add(HumanoRequest humanoRequest);
        public HumanoResponse Update(HumanoRequest humanoRequest);

    }
}
