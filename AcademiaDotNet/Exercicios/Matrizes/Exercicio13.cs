namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio13
    {
        // 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma
        // dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.

        public static void SomaDiagonais()
        {
            //int[,] matriz = new int[5, 5];
            int[,] matriz = { { 3, 2, 4, 2, 3 }, { 5, 3, 2, 3, 4 }, { 5, 2, 3, 1, 1 }, { 5, 3, 5, 3, 5 }, { 3, 5, 2, 5, 3 } };
            //int[,] matriz = { { 3, 2, 4, 2, 3 }, { 5, 3, 2, 3, 4 }, { 5, 2, 3, 1, 1 }, { 5, 3, 5, 3, 5 }, { 3, 5, 2, 5, 2 } };
            int somaPrincipal = 0, somaSecundaria = 0;
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //matriz[i, j] = rng.Next(10);
                    if (i == j)
                    {
                        somaPrincipal += matriz[i, j];
                    }

                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        somaSecundaria += matriz[i, j];
                    }
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Soma da diagonal principal é: {somaPrincipal}");
            Console.WriteLine($"Soma da diagonal secundária é: {somaSecundaria}");

            if (somaPrincipal == somaSecundaria)
            {
                Console.WriteLine("Soma dos elementos iguais");
            }
            else
            {
                Console.WriteLine("Soma dos elementos diferentes");
            }
        }
    }
}
