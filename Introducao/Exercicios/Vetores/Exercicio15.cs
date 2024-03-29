﻿namespace Introducao.Exercicios.Vetores
{
    internal class Exercicio15
    {
        // 15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos
        // do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do
        // primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por
        // exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

        public static void Inveter()
        {
            int[] vetor = new int[20];
            int[] vetorInverso = new int[20];
            byte j = 0;
            Random rng = new();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rng.Next(byte.MaxValue);
            }

            Console.WriteLine(String.Join(" | ", vetor));
            Console.WriteLine();
            Console.WriteLine();
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                vetorInverso[j] = vetor[i];
                j++;
            }
            Console.WriteLine(String.Join(" | ", vetorInverso));
        }
    }
}
