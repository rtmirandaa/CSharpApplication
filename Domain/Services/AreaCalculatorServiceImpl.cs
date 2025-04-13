using Domain.Entities;
using Application.Interfaces;
using Application.Dtos;

namespace Domain.Services
{
    public class AreaCalculatorServiceImpl : IFormaGeometrica
    {
        public double CalcularArea(CalculoAreaRequest request)
        {
            FormaGeometrica forma = request.Forma switch
            {
                "Quadrado" => new Quadrado(request.Lado),
                "Retangulo" => new Retangulo(request.Base, request.Altura),
                "TrianguloRetangulo" => new TrianguloRetangulo(request.Base, request.Altura),
                _ => throw new ArgumentException("Forma geométrica inválida")
            };
            return forma.CalcularArea();
        }
    }
}
