namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio17
    {
        // 17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor
        // elemento da linha onde se encontra o maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.

        public static void MinMax()
        {
            int[,] matriz = new int[10, 10];
            int min, max = 0, posMinX = 0, posMinY = 0, posMaxX = 0, posMaxY = 0;
            Random rng = new();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(99);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            min = matriz[0, 0];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (min > matriz[i, j])
                    {
                        min = matriz[i, j];
                        posMinX = i;
                        posMinY = j;
                    }
                    else if (max < matriz[i, j])
                    {
                        max = matriz[i, j];
                        posMaxX = i;
                        posMaxY = j;
                    }
                }
            }
            Console.WriteLine($"O valor máximo {max} estava na linha {posMaxX} e coluna {posMaxY}");
            Console.WriteLine($"O valor máximo {min} estava na linha {posMinX} e coluna {posMinY}");
        }
    }
}
