using ReclutamientoGuillermoNassi.Requests;
using ReclutamientoGuillermoNassi.Responses;

namespace ReclutamientoGuillermoNassi.Services
{
    public class OperacionService : IOperacionService
    {
        public decimal Division(decimal A, decimal B)
        {
            return A / B;
        }

        public decimal Multiplicacion(decimal A, decimal B)
        {
            return A * B;
        }

        public OperacionResponse Operacion(OperacionRequest operacionRequest)
        {
            OperacionResponse operacionResponse = new();
            switch ((operacionRequest.Operacion)
)
            {
                case ("suma"): operacionResponse.Result = Suma(operacionRequest.A, operacionRequest.B);
                    break;
                case ("resta"):
                    operacionResponse.Result = Resta(operacionRequest.A, operacionRequest.B);
                    break;
                case ("multiplicacion"):
                    operacionResponse.Result = Multiplicacion(operacionRequest.A, operacionRequest.B);
                    break;
                case ("division"):
                    operacionResponse.Result = Division(operacionRequest.A, operacionRequest.B);
                    break;
                default:
                    throw new Exception();
            }
            return operacionResponse;
        }

        public decimal Resta(decimal A, decimal B)
        {
            return A - B;
        }

        public decimal Suma(decimal A, decimal B)
        {
            return A + B;
        }
    }

}
