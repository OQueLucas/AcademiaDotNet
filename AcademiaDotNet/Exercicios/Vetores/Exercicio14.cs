namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio14
    {
        // 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
        // Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido.
        // Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

        public static void Codigo()
        {
            int[] vetor = new int[50];
            int[] vetorInverso = new int[50];
            byte j = 0;
            byte codigo;
            Random rng = new();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rng.Next(byte.MaxValue);
            }

            Console.WriteLine("Digite 0 para encerrar / 1 para mostrar vetor em ordem / 2 para mostrar vetor inverso: ");
            codigo = byte.Parse(Console.ReadLine());

            if (codigo == 0)
            {
                Environment.Exit(0);
            }
            else if (codigo == 1)
            {
                Console.WriteLine(String.Join(" | ", vetor));
            }
            else if (codigo == 2)
            {
                Console.WriteLine(String.Join(" | ", vetor));
                Console.WriteLine();
                Console.WriteLine();
                for (int i = vetor.Length - 1; i >= 0; i--)
                {
                    vetorInverso[j] = vetor[i];
                    j++;
                }
                Console.WriteLine(String.Join(" | ", vetorInverso));
            }
        }
    }
}
