namespace AcademiaDotNet.ExercicioVetores
{
    internal class Exercicio10
    {
        // 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor,
        // substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

        public static void SubstituirNulo()
        {
            int[] a = new int[20];
            string[] entrada = new string[20];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                entrada[i] = Console.ReadLine();
                bool b = int.TryParse(entrada[i], out int valor);

                if (b == false || valor == 0)
                {
                    a[i] = 2;
                }
                else
                {
                    a[i] = valor;
                }
            }

            Console.WriteLine(String.Join(" | ", entrada));
            Console.WriteLine(String.Join(" | ", a));
        }
    }
}
