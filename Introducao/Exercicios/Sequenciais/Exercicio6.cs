namespace Introducao.Exercicios.Sequenciais
{
    internal class Exercicio6
    {
        // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
        // isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
        // de IPI(única) a ser acrescentada.
        public static void Parafuso()
        {
            DadosParafuso("A");
            DadosParafuso("B");
        }

        static void DadosParafuso(string valor)
        {
            Console.WriteLine($"Insira os dados do parafuso {valor}: ");
            Console.Write("Codigo: ");
            string codigo = Console.ReadLine();
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double valorUnitario = double.Parse(Console.ReadLine());
            Console.Write("Porcentagem de IPI: ");
            double ipi = double.Parse(Console.ReadLine());
        }
    }
}
