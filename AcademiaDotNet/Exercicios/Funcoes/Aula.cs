namespace AcademiaDotNet.Exercicios.Funcoes
{
    internal class Aula
    {
        static double a, b;
        static void SomaNovo(double a, double b)
        {
            Console.WriteLine("O resultado da soma é: " + (a + b));
        }

        static void Ler2Numeros()
        {
            Console.WriteLine("Digite dois numeros: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
        }

        static void Soma()
        {
            double soma = a + b;
            Console.WriteLine("O resultado da soma é: " + soma);
        }
    }
}
