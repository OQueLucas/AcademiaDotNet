namespace Introducao.Exercicios.Funcoes2
{
    internal class Exercicio1
    {
        // 1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o 
        // maior elemento da matriz.Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

        public static int[,] LerMatriz()
        {
            int[,] matriz = new int[10, 10];
            Random rng = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rng.Next(10, 99);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return matriz;
        }

        public static string Minimax(int[,] matriz)
        {
            int maior = matriz[0, 0];
            int linha = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linha = i;
                    }
                }
            }

            int menor = maior;

            Console.WriteLine("maior valor: "+maior);
            Console.WriteLine("linha: "+linha);

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if ( menor > matriz[linha, j])
                {
                    menor = matriz[linha, j];
                }
            }
            return $"valor {menor} é o Minimax";
        }
    }
}
