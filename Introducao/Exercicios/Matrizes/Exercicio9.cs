namespace Introducao.Exercicios.Matrizes
{
    internal class Exercicio9
    {
        // 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
        // Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
        public static void EncontrarValor()
        {
            int[,] matriz = new int[3, 3];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Digite o valor que deseja encontrar: ");
            int numero = int.Parse(Console.ReadLine());
            int aux = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        aux++;
                        break;
                    }
                }
                if (aux > 0)
                {
                    break;
                }
            }

            if (aux > 0)
            {
                Console.WriteLine("O número existe no vetor");
            }
            else
            {
                Console.WriteLine("Número inexistente");
            }
        }
    }
}
