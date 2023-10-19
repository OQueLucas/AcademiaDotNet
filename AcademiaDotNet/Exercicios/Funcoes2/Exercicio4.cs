namespace AcademiaDotNet.Exercicios.Funcoes2
{
    internal class Exercicio4
    {
        // 4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.

        public static int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
        {
            int[,] soma = new int[matriz1.GetLength(0), matriz1.GetLength(1)];

            for (int i = 0; i < soma.GetLength(0); i++)
            {
                for (int j = 0; j < soma.GetLength(1); j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            return soma;
        }
    }
}
