namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio2
    {
        // 2. Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma
        // dos elementos da mesma posição, armazenando o resultado em um outro vetor.
        public static void SomaVetor()
        {
            int[] v1 = new int[20];
            int[] v2 = new int[20];
            int[] soma = new int[20];
            Random rnd = new();

            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write($"Insira o valor {i} do vetor: ");
                v1[i] = rnd.Next(byte.MaxValue);
                Console.WriteLine(v1[i]);
                //v1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write($"Insira o valor {i} do vetor: ");
                v2[i] = rnd.Next(byte.MaxValue);
                Console.WriteLine(v2[i]);
                //v2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < soma.Length; i++)
            {
                soma[i] = v1[i] + v2[i];
                Console.WriteLine($"Soma de {v1[i]} + {v2[i]} = {soma[i]}");
            }

        }
    }
}
