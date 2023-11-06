namespace AbstracaoExercicio3
{
    internal class Circulo : IFormaGeometrica
    {
        readonly double PI = 3.14;

        public Circulo(int raio)
        {
            Raio = raio;
        }

        public int Raio { get; set; }

        public void CalcularArea()
        {
            Console.WriteLine(PI * (Raio * Raio));
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine(2 * PI * Raio);
        }
    }
}
