namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio11
    {
        // 11.	Escreva um programa que leia valores em um vetor de 5 posições.
        // Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

        public static void Inverso()
        {
            int[] vetor = new int[5];
            int[] vetorInverso = new int[5];
            byte j = 0;
            Random rnd = new();

            for (int i = 0; i < 5; i++)
            {
                vetor[i] = rnd.Next(Byte.MaxValue);
            }

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                vetorInverso[j] = vetor[i];
                j++;
            }

            Console.WriteLine(String.Join(" | ", vetor));
            Console.WriteLine(String.Join(" | ", vetorInverso));
        }
    }
}
