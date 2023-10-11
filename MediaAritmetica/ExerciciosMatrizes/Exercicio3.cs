namespace AcademiaDotNet.ExerciciosMatrizes
{
    internal class Exercicio3
    {
        // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
        public static void Diagonal()
        {
            int[,] matriz = new int[4, 4];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }
        }
    }
}
