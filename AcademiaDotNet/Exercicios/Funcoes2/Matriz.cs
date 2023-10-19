namespace AcademiaDotNet.Exercicios.Funcoes2
{
    internal class Matriz
    {
        public Matriz() { }

        public void EscreverMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int[,] Gerar(int linhas, int colunas, int min, int max)
        {
            int[,] matriz = new int[linhas, colunas];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(min, max);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return matriz;
        }
    }
}
