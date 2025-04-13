namespace Domain.Entities
{
    public class Retangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRetangulo, double altura)
        {
            if (baseRetangulo <= 0 || altura <= 0)
                throw new ArgumentException("Base e altura devem ser maiores que zero.");
            Base = baseRetangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
