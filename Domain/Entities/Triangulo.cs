namespace Domain.Entities
{
    public class TrianguloRetangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public TrianguloRetangulo(double baseTriangulo, double altura)
        {
            if (baseTriangulo <= 0 || altura <= 0)
                throw new ArgumentException("Base e altura devem ser maiores que zero.");
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
