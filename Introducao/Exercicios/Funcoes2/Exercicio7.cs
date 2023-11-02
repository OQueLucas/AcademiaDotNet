namespace Introducao.Exercicios.Funcoes2
{
    internal class Exercicio7
    {
        // 7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro e
        // retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.

        public static bool VerificarNumeroPrimo()
        {
            // Numeros primos (2, 3, 5, 7, 11, 13, 17, 19)
            int[] vetor = new int[] { 1, 4, 6, 8, 12, 14, 18, 20 };

            for (int i = 0; i < vetor.Length; i++)
            {
                int count = 0;
                Console.WriteLine(vetor[i]);

                for (int j = 1; j < vetor[i]; j++)
                {
                    if (vetor[i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
