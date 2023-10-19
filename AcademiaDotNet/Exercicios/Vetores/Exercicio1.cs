namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio1
    {
        // 1. Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

        public static void ParesImpares()
        {
            int[] v = new int[10];
            int contPar = 0, contImpar = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"Insira o {i + 1} vetor: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] % 2 == 0)
                {
                    contPar++;
                }
                else
                {
                    contImpar++;
                }
            }

            Console.WriteLine($"Foi inserido {contPar} numero pares e {contImpar} numero impares.");
        }
    }
}
