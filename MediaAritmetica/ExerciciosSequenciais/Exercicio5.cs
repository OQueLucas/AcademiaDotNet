namespace AcademiaDotNet.ExerciciosSequenciais
{
    internal class Exercicio5
    {
        // 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
        // (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível
        // consumido para percorrê-la(medido em l).
        public static void ConsumoMedio()
        {
            double km = 14;
            double litros = 3;

            double media = km / litros;

            Console.WriteLine($"O carro percorre {media.ToString("F2")} por litro");
        }
    }
}
