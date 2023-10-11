namespace AcademiaDotNet.ExerciciosMatrizes
{
    internal class Exercicio11
    {
        // 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

        public static void Divisao()
        {
            float[,] a = new float[3, 3];
            float[,] b = new float[3, 3];
            Random rng = new();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rng.Next(10);
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        b[i, j] = 0;
                    }
                    else
                    {
                        b[i, j] = a[i, j] / (i + j);
                    }
                    Console.Write(b[i, j].ToString("F1") + "\t");

                }
                Console.WriteLine();
            }

        }
    }
}
