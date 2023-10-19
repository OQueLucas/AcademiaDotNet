namespace AcademiaDotNet.Exercicios.Sequenciais
{
    internal class Exercicio8
    {
        // 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
        // A fórmula da conversão é F = (9 * C + 160) / 5.
        public static void ConversaoFahrenheit()
        {
            double fahrenheit, celsius;

            Console.Write("Insira o numero em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"A temperatura {celsius}°C equivale a {fahrenheit}°F.");
        }

    }
}
