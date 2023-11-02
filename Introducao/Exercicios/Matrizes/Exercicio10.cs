namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio10
    {
        // 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

        public static void Media()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            int total = 0, cont = 0, acimaMedia = 0, abaixoMedia = 0, naMedia = 0;
            Random rng = new();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rng.Next(10);
                    Console.Write(a[i, j] + " ");
                    total += a[i, j];
                    cont++;
                }
                Console.Write("\t");
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = rng.Next(10);
                    Console.Write(b[i, j] + " ");
                    total += b[i, j];
                    cont++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            float media = total / cont;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > media)
                    {
                        Console.Write("↑ ");
                        acimaMedia++;
                    }
                    else if (a[i, j] < media)
                    {
                        Console.Write("↓ ");
                        abaixoMedia++;
                    }
                    else if (a[i, j] == media)
                    {
                        Console.Write("= ");
                        naMedia++;
                    }
                }
                Console.Write("\t");
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (b[i, j] > media)
                    {
                        Console.Write("↑ ");
                        acimaMedia++;
                    }
                    else if (b[i, j] < media)
                    {
                        Console.Write("↓ ");
                        abaixoMedia++;
                    }
                    else if (b[i, j] == media)
                    {
                        Console.Write("= ");
                        naMedia++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"A media é: {media}");
            Console.WriteLine($"Quantidade a cima da media é: {acimaMedia}");
            Console.WriteLine($"Quantidade a baixo da media é: {abaixoMedia}");
            Console.WriteLine($"Quantidade na media é: {naMedia}");

        }
    }
}
