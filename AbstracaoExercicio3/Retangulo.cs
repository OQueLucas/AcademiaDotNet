namespace AbstracaoExercicio3
{
    internal class Retangulo : IFormaGeometrica
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Retangulo(int b, int a)
        {
            Base = b;
            Altura = a;
        }

        public void CalcularArea()
        {
            Console.WriteLine(Base * Altura);
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine(2 * (Base + Altura));
        }
    }
}
