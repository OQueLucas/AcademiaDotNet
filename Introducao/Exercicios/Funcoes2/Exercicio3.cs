namespace Introducao.Exercicios.Funcoes2
{
    internal class Exercicio3
    {
        // 3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.

        public static void TransporMatriz(int[,] matriz)
        {
            int[,] matrizTransposta = new int[matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizTransposta[j, i] = matriz[i, j];
                }
            }


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matrizTransposta[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
