namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio15
    {
        // 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

        public static void Soma()
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int[,] soma = new int[4, 4];
            Random rng = new();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = rng.Next(10);
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = rng.Next(10);
                    Console.Write(matrizB[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    soma[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.Write(soma[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
