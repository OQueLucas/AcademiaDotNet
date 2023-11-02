namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio8
    {
        // 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
        // Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
        // Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
        // E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
        // total de vendas.

        public static void ComissaoFuncionario()
        {
            Console.WriteLine("Insira o código do funcionário: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Insira o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o salário base: ");
            float salarioBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas: ");
            float totalVendas = float.Parse(Console.ReadLine());

            float salarioFinal;

            if (totalVendas > 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.1F);
            }
            else if (totalVendas > 1000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.07F);
            }
            else if (totalVendas > 500)
            {
                salarioFinal = salarioBase + (totalVendas * 0.05F);
            }
            else
            {
                salarioFinal = salarioBase;
            }

            Console.WriteLine($"salario do funcionário {nome} codigo {codigo} é R$ {salarioFinal}");
        }
    }
}