namespace Introducao.Exercicios.Repeticao
{
    internal class Exercicio5
    {
        // 5. Escreva um algoritmo para calcular o fatorial de um número.
        public static void Fatorial()
        {
            int fatorial = 7;

            for (int i = fatorial - 1; i > 1; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
