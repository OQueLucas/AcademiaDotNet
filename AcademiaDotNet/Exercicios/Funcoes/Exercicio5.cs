namespace AcademiaDotNet.Exercicios.Funcoes
{
    internal class Exercicio5
    {
        // 5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.
        public static void ConverterCelsiusParaFahrenheit()
        {
            Console.WriteLine("Digite a temperatura em celsius: ");
            double celcius = double.Parse(Console.ReadLine());
            double fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine(fahrenheit + "ºF");
        }
    }
}
