namespace Introducao.Exercicios.Funcoes
{
    internal class Desafio
    {
        // Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.

        public static int[] LerVetor()
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            return vetor;
        }

        public static int Menor(int[] vetor)
        {
            int menor = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }

            return menor;
        }
    }
}
