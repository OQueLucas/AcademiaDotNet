namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio1
    {
        // 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna,
        // some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

        public static void Matriz()
        {
            int[,] matriz = new int[5, 3];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //Console.WriteLine($"Insira o valor {i}: ");
                //matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 0] = rng.Next(100);
                Console.Write(matriz[i, 0] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
                Console.Write(matriz[i, 1] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i <= matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
                Console.Write(matriz[i, 2] + " ");
            }

        }
    }
}
