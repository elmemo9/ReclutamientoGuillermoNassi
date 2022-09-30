using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public interface IOperacionService
    {
        public OperacionResponse Operacion(OperacionRequest operacionRequest);
        public decimal Suma(decimal A, decimal B);
        public decimal Resta(decimal A, decimal B);
        public decimal Multiplicacion(decimal A, decimal B);
        public decimal Division(decimal A, decimal B);
    }
}
