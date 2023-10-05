namespace AcademiaDotNet.ExerciciosSequenciais
{
    internal class Exercicio13
    {
        // 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o
        // preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
        // vendidas pelo vendedor, calcule e mostre: o salário do empregado

        public static void SalarioVendedor()
        {
            Console.WriteLine("Insira o valor do salário mínimo");
            float salarioMinimo = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço de custo da bicicleta: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de bicicletas vendidas pelo vendedor: ");
            int vendas = int.Parse(Console.ReadLine());

            float salarioTotal = (salarioMinimo * 2) + (preco * 0.15F * vendas);

            Console.WriteLine($"O salário do empregado é: {salarioTotal}");
        }
    }
}
