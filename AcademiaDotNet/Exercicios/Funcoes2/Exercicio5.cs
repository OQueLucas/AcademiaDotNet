namespace AcademiaDotNet.Exercicios.Funcoes2
{
    internal class Exercicio5
    {
        // 5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.

        public static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            return soma;
        }
    }
}
