namespace AcademiaDotNet.Exercicios.Sequenciais
{
    internal class Exercicio12
    {
        // 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
        // marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
        // dos passageiros.Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

        // Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

        // Média do consumo = Total quilometragem/ quantidade de combustível gasto

        // Lucro do dia = Valor total recebido - (quantidade de combustível gasto* 6,90)

        public static void Taximetro()
        {
            Console.WriteLine("Digite a marcação inicial do dia do odômetro: ");
            float inicial = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a marcação final do dia do odômetro: ");
            float final = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de litro de combustível gasto: ");
            int litros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor total recebido dos passageiros: ");
            float valor = float.Parse(Console.ReadLine());

            float totalKm = final - inicial;

            float mediaConsumo = totalKm / (float)litros;

            float lucro = valor - ((float)litros * 6.90F);

            Console.WriteLine($"A média de consumo em Km/l é {mediaConsumo}.");
            Console.WriteLine($"E o lucro líquido do dia foi de R$ {lucro}.");
        }
    }
}
