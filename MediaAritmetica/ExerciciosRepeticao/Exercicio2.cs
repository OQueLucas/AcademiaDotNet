namespace AcademiaDotNet.ExerciciosRepeticao
{
    internal class Exercicio2
    {
        // 2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

        public static void Maior()
        {
            int maior = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o valor do {i + 1}º numero: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor > maior)
                {
                    maior = valor;
                }
            }
            Console.WriteLine($"O maior valor é {maior}");
        }
    }
}
