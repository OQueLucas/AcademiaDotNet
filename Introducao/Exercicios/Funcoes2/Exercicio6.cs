namespace Introducao.Exercicios.Funcoes2
{
    internal class Exercicio6
    {
        // 6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.

        public static int MediaColunaMatriz(int[,] matriz, int coluna)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, coluna];
            }
            return soma;
        }
    }
}
