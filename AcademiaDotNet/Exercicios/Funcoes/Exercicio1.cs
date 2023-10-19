namespace AulaFuncoes
{
    internal class Exercicio1
    {
        // 1) Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.
        public static void Soma(double a, double b)
        {
            Console.WriteLine("Resultado da soma é: " + (a + b));
        }
        public static void Subtracao(double a, double b)
        {
            Console.WriteLine("Resultado da subtracao é: " + (a - b));
        }
        public static void Multiplicacao(double a, double b)
        {
            Console.WriteLine("Resultado da multiplicacao é: " + (a * b));
        }
        public static void Divisao(double a, double b)
        {
            Console.WriteLine("Resultado da divisao é: " + (a / b));
        }
    }
}
