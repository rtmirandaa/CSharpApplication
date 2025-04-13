using Application.Dtos;

namespace Application.Interfaces
{
    public interface IFormaGeometrica
    {
        double CalcularArea(CalculoAreaRequest request);
    }
}
