namespace AcademiaDotNet.ExercicioVetores
{
    internal class Exercicio9
    {
        // 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
        // e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

        public static void OrganizaVetor()
        {

            int[] a = new int[10];
            Random rnd = new();
            int aux;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(byte.MaxValue);
            }
            Console.WriteLine(String.Join(" | ", a));
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        aux = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine(String.Join(" | ", a));
        }
    }
}
