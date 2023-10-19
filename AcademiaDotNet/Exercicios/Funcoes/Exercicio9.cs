namespace AcademiaDotNet.Exercicios.Funcoes
{
    internal class Exercicio9
    {
        // 9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) e retorna
        // a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos). Apresente o resultado na main.

        public static void Soma(int n1, int n2)
        {
            int total = 0;
            for(int i = n1; i <= n2; i++)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
    }
}
