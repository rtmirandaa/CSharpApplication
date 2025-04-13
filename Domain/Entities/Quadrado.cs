namespace Domain.Entities
{
    public class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("O lado do quadrado deve ser maior que zero.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
    }
}
