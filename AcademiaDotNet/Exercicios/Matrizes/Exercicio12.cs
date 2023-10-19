namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio12
    {
        // 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

        public static void Par()
        {
            int[,] matriz = new int[4, 4];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
