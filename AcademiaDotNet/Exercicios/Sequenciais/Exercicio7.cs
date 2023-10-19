namespace AcademiaDotNet.Exercicios.Sequenciais
{
    internal class Exercicio7
    {
        // 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
        // o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.
        // Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
        public static void SalarioVendedor()
        {
            Console.Write("Insira o número do vendedor: ");
            string numero = Console.ReadLine();
            Console.Write("Insira o salário fixo: ");
            float salarioFixo = float.Parse(Console.ReadLine());
            Console.Write("Insira o total de vendas: ");
            float vendas = float.Parse(Console.ReadLine());
            Console.Write("Insira o percentual de Vendas: ");
            float percentualVendas = float.Parse(Console.ReadLine());

            float salarioTotal = (vendas * percentualVendas) / 100 + salarioFixo;

            Console.WriteLine($"o vendedor {numero} tem o salário total de {salarioTotal}");
        }
    }
}
