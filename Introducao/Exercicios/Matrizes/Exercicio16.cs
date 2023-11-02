namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio16
    {
        // 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

        public static void Transpor()
        {
            int[,] matrizA = new int[3, 4];
            int[,] matrizB = new int[4, 3];
            Random rng = new Random();

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = rng.Next(10);
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = matrizA[j, i];
                    Console.Write(matrizB[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }
    }
}
