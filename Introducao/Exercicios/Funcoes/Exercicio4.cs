namespace Introducao.Exercicios.Funcoes
{
    internal class Exercicio4
    {
        // 4) Escreva uma função que calcule o fatorial de um número inteiro positivo.
        public static void Fatorial(int valor)
        {
            int total = valor;
            for (int i = valor - 1; i > 0; i--)
            {
                total *= i;
            }
            Console.WriteLine(total);
        }
    }
}
