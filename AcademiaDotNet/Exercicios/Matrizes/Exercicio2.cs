namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio2
    {
        // 2) Solicite ao usuário, preencher uma Matriz 3x3

        // Informe ao usuário:
        // *A soma dos elementos de cada linha
        //	-Ex: Linha 1: 30
        // Linha 2: 17
        // *A soma dos elementos de cada coluna
        //	-Ex: Coluna 1: 23
        //	     Coluna 2: 36

        public static void SomaMatriz()
        {
            int[,] matriz = new int[3, 3];
            Random rng = new();
            int[] somaLinha = new int[3];
            int[] somaColuna = new int[3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somax = 0;
                int somay = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somax += matriz[i, j];
                    somay += matriz[j, i];
                }
                somaLinha[i] = somax;
                somaColuna[i] = somay;
            }

            Console.WriteLine(String.Join(" | ", somaLinha));

            Console.WriteLine(String.Join(" | ", somaColuna));
        }
    }
}
