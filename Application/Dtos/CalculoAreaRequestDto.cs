namespace Application.Dtos
{
    public class CalculoAreaRequest
    {
        public required string Forma { get; set; } 
        public required double Lado { get; set; } 
        public required double Base { get; set; } 
        public required double Altura { get; set; }
    }
}
