namespace AcademiaDotNet.ExercicioVetores
{
    internal class Exercicio4
    {
        // 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos
        // elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

        public static void MultiplicaVetor()
        {
            int[] v1 = new int[20];
            int[] v2 = new int[20];
            int[] result = new int[20];
            Random rnd = new();

            for (int i = 0; i < v1.Length; i++)
            {
                v1[i] = rnd.Next(100);
                Console.WriteLine(v1[i]);
            }
            for (int i = 0; i < v2.Length; i++)
            {
                v2[i] = rnd.Next(100);
                Console.WriteLine(v2[i]);
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = v1[i] * v2[i];
                Console.WriteLine($"Resultado de {v1[i]} x {v2[i]} = {result[i]}");
            }
        }
    }
}
