namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio6
    {
        // 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
        // Random random = new Random();
        // int randomNumber = random.Next(0, 100);

        public static void MaiorNumero()
        {
            int[,] matriz = new int[4, 4];
            Random rng = new Random();
            int maior = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(0, 9);
                    Console.Write(matriz[i, j] + " ");
                    if (maior < matriz[i, j])
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("maior número é: " + maior);
        }
    }
}
