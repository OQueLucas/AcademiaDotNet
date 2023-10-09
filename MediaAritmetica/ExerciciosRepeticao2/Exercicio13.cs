namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio13
    {
        // 13. Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.
        public static void SomaPares()
        {

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                    Console.WriteLine($"{i} = {soma}");
                }
            }
        }
    }
}
