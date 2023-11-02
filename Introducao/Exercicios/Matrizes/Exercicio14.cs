namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio14
    {
        // 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal
        // principal (da esquerda para a direita) são os mesmos da diagonal
        // secundária(direita pra esquerda).
        public static void VerificaElementos()
        {
            int[,] matriz = new int[5, 5];
            //int[,] matriz = { { 3, 2, 4, 2, 3 }, { 5, 3, 2, 3, 4 }, { 5, 2, 3, 1, 1 }, { 5, 3, 5, 3, 5 }, { 3, 5, 2, 5, 3 } };
            //int[,] matriz = { { 3, 2, 4, 2, 3 }, { 5, 3, 2, 7, 4 }, { 5, 2, 3, 1, 1 }, { 5, 9, 5, 9, 5 }, { 3, 5, 2, 5, 2 } };
            int elementoPrincipal = 0, elementoSecundario = 0;
            Random rng = new();

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
                if (i == 2)
                {
                    break;
                }
                string principal = "", secundaria = "";
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        elementoPrincipal = matriz[i, j];
                        principal = $"[{i}/{j}]";
                    }
                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        elementoSecundario = matriz[i, j];
                        secundaria = $"[{i}/{j}]";
                    }
                }
                if (elementoPrincipal == elementoSecundario)
                {
                    Console.WriteLine($"elemento {principal} {elementoPrincipal} é igual ao elemento {secundaria} {elementoSecundario}");
                }
            }
        }
    }
}
