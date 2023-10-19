namespace AcademiaDotNet.Exercicios.Repeticao2
{
    internal class Exercicio12
    {
        public static void SomaNumerosInteiros()
        {
            // 12.Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine($"{i} = {soma}");
            }
        }
    }
}
