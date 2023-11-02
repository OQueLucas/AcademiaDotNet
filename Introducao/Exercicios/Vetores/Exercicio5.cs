namespace Introducao.Exercicios.Vetores
{
    internal class Exercicio5
    {
        // 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

        public static void MenorElemento()
        {
            int[] vetor = new int[80];
            int menorValor, indiceMenorValor = 0;
            Random rnd = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rnd.Next(byte.MaxValue);
            }
            Console.WriteLine(String.Join(" | ", vetor));

            menorValor = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (menorValor > vetor[i])
                {
                    menorValor = vetor[i];
                    indiceMenorValor = Array.IndexOf(vetor, vetor[i]);
                }
            }

            Console.WriteLine($"O menor valor é {menorValor} na posição {indiceMenorValor}");

        }
    }
}
