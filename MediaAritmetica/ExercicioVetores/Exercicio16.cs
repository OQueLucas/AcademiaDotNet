namespace AcademiaDotNet.ExercicioVetores
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
            int[] x = new int[10];
            int[] y = new int[10];
            Random rng = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rng.Next(20);
                y[i] = rng.Next(20);
            }
            Console.WriteLine(String.Join(" | ", x));
            Console.WriteLine(String.Join(" | ", y));
            Console.WriteLine(String.Join(" | ", Uniao(x, y)));
            //Console.WriteLine(String.Join(" | ", Diferenca(x, y)));

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
                    if (x[i] == y[j])
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
                bool existe = false;

                for (int j = 0; j < x.Length; j++)
                {
                    int arrayX = x[j];
                    int arrayY = y[i];

                    if (arrayX == arrayY)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    uniao[iUniao] = y[i];
                    iUniao++;
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
                    if (x[i] == y[j])
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
                bool existe = false;

                for (int j = 0; j < y.Length; j++)
                {
                    int arrayX = x[j];
                    int arrayY = y[i];

                    if (arrayX == arrayY)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    diferenca[iUniao] = x[i];
                    iUniao++;
                }
            }
            return diferenca;
        }


    }
}
