namespace AcademiaDotNet.ExerciciosMatrizes
{
    internal class Exercicio4
    {

        // 4) Popule uma matriz 5x5 e informe:
        // -Quantos números são pares
        // -Quantos números são impares
        // -Quantos números são positivos
        // -Quantos números são negativos
        // -Quantos zeros existem!

        public static void Matriz()
        {
            int[,] matriz = new int[5, 5];
            Random rng = new Random();
            int par = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(-10, 10);
                    Console.Write(matriz[i, j] + " ");

                    if (matriz[i, j] % 2 == 0) { par++; } else { impar++; }

                    if (matriz[i, j] > 0) { positivo++; } else { negativo++; }

                    if (matriz[i, j] == 0) { zero++; }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("A matriz possui: ");

            Console.WriteLine($"{par} numeros pares");
            Console.WriteLine($"{impar} numeros impares");
            Console.WriteLine($"{positivo} numeros positivos");
            Console.WriteLine($"{negativo} numeros negativos");
            Console.WriteLine($"{zero} numeros zeros");

        }
    }
}
