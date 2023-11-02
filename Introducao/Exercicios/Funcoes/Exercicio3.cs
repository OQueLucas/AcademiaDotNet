namespace Introducao.Exercicios.Funcoes
{
    internal class Exercicio3
    {
        // 3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.
        public static void Media(double a, double b, double c)
        {
            double media = (a + b + c) / 3;
            Console.WriteLine("Média é " + media.ToString("F2"));
        }
    }
}
