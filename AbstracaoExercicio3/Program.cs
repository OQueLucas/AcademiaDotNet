namespace AbstracaoExercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
            Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
            Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, de forma que o "Retangulo" calcule a área e 
            o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo. */

            Circulo c = new(8);

            c.CalcularPerimetro();
            c.CalcularArea();

            Retangulo r = new(12, 5);

            r.CalcularPerimetro();
            r.CalcularArea();
        }
    }
}