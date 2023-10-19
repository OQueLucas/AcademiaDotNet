namespace AcademiaDotNet.Exercicios.Matrizes
{
    internal class Exercicio5
    {
        // 5) Leia duas matrizes 2x3 de números double. 
        // Imprima a soma destas duas matrizes

        public static void Soma()
        {
            int[,] matrizM = new int[2, 3];
            int[,] matrizN = new int[2, 3];
            int[,] soma = new int[2, 3];
            Random rng = new Random();

            for (int i = 0; i < matrizM.GetLength(0); i++)
            {
                for (int j = 0; j < matrizM.GetLength(1); j++)
                {
                    matrizM[i, j] = rng.Next(10);
                    Console.Write(matrizM[i, j] + " + ");
                    matrizN[i, j] = rng.Next(10);
                    Console.Write(matrizN[i, j] + " = ");
                    soma[i, j] = matrizM[i, j] + matrizN[i, j];
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
