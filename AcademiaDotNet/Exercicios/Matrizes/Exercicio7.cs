namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio7
    {
        // 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
        public static void Subtracao()
        {
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            Random rng = new Random();
            int[,] c = new int[4, 4];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rng.Next(10);
                    Console.Write(a[i, j] + " - ");
                    b[i, j] = rng.Next(10);
                    Console.Write(b[i, j] + " = ");
                    c[i, j] = a[i, j] - b[i, j];
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
