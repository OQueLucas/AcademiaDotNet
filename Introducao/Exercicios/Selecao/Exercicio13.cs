namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio13
    {
        // 13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
        // seu peso ideal, utilizando as seguintes fórmulas:
        // Para homens: (72.7 * h) - 58
        // Para mulheres: (62.1 * h) - 44.7

        public static void PesoIdeal()
        {
            float pesoIdeal = 0;

            Console.WriteLine("Insira sua altura: ");
            float h = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite h para homem e m para mulher: ");
            char sexo = char.Parse(Console.ReadLine());

            if (sexo == 'h')
            {
                pesoIdeal = (72.7F * h) - 58;
            }
            else
            if (sexo == 'm')
            {
                pesoIdeal = (62.1F * h) - 44.7f;
            }

            Console.WriteLine($"Peso ideal é {pesoIdeal}");
        }
    }
}
