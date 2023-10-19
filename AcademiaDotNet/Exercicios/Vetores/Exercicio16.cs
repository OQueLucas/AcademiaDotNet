namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio16
    {
        // 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
        // •	A união de X com Y
        // •	A diferença entre X e Y
        // •	A interseção entre X e Y
        // Escreva o vetor resultado de cada uma das operações.

        // UNIÃO: todos os elementos de X, e todos os elementos de Y que nao estao em X.
        // DIFERENÇA:  todos os elementos de X que não existem em Y
        // INTERSECÇÃO: Apenas os elementos que aparecem nos 2 vetores

        public static void Operacoes()
        {
            //int[] x = new int[10];
            //int[] y = new int[10];
            //Random rng = new();
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = rng.Next(20);
            //    y[i] = rng.Next(20);
            //}

            int[] x = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] y = { 0, 5, 7, 9, 12, 13, 18, 1, 15, 19 };

            Console.WriteLine("X:\t\t" + String.Join("\t", x) + "\n");
            Console.WriteLine("Y:\t\t" + String.Join("\t", y) + "\n");
            Console.WriteLine("União:\t\t" + String.Join("\t", Uniao(x, y)) + "\n");
            Console.WriteLine("Diferença:\t" + String.Join("\t", Diferenca(x, y)) + "\n");
            Console.WriteLine("Diferença:\t" + String.Join("\t", Diferenca(y, x)) + "\n");
            Console.WriteLine("Intersecção:\t" + String.Join("\t", Interseccao(x, y)) + "\n");

        }

        public static int[] Uniao(int[] x, int[] y)
        {
            int[] uniao;
            int tamanho = 10;

            for (int i = 0; i < y.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[j] == y[i])
                    {
                        cont++;
                    }
                }
                if (cont > 0)
                {
                    tamanho--;
                }
            }

            uniao = new int[10 + tamanho];
            int iUniao = 10;
            for (int i = 0; i < y.Length; i++)
            {
                uniao[i] = x[i];

                for (int j = 0; j < x.Length; j++)
                {
                    if (x[j] == y[i])
                    {
                        break;
                    }
                    if (j == (y.Length - 1))
                    {
                        uniao[iUniao] = y[i];
                        iUniao++;
                    }
                }

            }
            return uniao;
        }

        public static int[] Diferenca(int[] x, int[] y)
        {
            int[] diferenca;
            int tamanho = 10;

            for (int i = 0; i < x.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[j] == y[i])
                    {
                        cont++;
                    }
                }
                if (cont > 0)
                {
                    tamanho--;
                }
            }

            diferenca = new int[tamanho];
            int iUniao = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if (j == (y.Length - 1))
                    {
                        diferenca[iUniao] = x[i];
                        iUniao++;
                    }
                }
            }
            return diferenca;
        }

        public static int[] Interseccao(int[] x, int[] y)
        {
            int[] interseccao;
            int tamanho = 10;

            for (int i = 0; i < x.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[j] == y[i])
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    tamanho--;
                }
            }

            interseccao = new int[tamanho];
            int iUniao = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        interseccao[iUniao] = x[i];
                        iUniao++;
                        break;
                    }
                }
            }
            return interseccao;
        }

    }
}
