namespace Introducao.Exercicios.Funcoes2
{
    internal class Exercicio2
    {
        // 2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o
        // usuário deseja escolher os pares ou os impares, e retorna a média dos valores conforme a escolha do usuário.

        public static void ChamadaCalcularMedia()
        {

            int[] vetor = new int[10];
            Random rng = new Random();
            char parImpar = 'X';

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rng.Next(1, 10);
            }
            Console.WriteLine(String.Join(" | ", vetor));

            Console.WriteLine("Deseja calcular (I)mpar ou (P)ar? ");
            parImpar = char.Parse(Console.ReadLine().ToUpper());

            if (parImpar != 'P' && parImpar != 'I')
            {
                throw new Exception("Valor inserido invalido!");
            }
            Console.WriteLine(CalcularMedia(vetor, parImpar)); ;

        }

        public static int CalcularMedia(int[] vetor, char parImpar)
        {
            int count = 0;
            int soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0 && parImpar == 'P')
                {
                    soma += vetor[i];
                    count++;
                }
                else if (vetor[i] % 2 != 0 && parImpar == 'I')
                {
                    soma += vetor[i];
                    count++;
                }
            }

            return soma / count;
        }
    }
}
