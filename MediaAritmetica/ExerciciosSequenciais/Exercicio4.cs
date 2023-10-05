namespace AcademiaDotNet.ExerciciosSequenciais
{
    internal class Exercicio4
    {
        // 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e
        // AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
        public static void AlterarFormatoData()
        {
            DateOnly data;

            // Console.WriteLine("Digite o primeiro valor: ");
            // data = DateOnly.Parse(Console.ReadLine());

            data = DateOnly.Parse(DateTime.Today.ToString("dd/MM/yyyy"));

            Console.WriteLine($"A data AAAAMMDD é {data.ToString("yyyy/MM/dd")} e a data AAMMDD {data.ToString("yy/MM/dd")}.");
        }
    }
}
