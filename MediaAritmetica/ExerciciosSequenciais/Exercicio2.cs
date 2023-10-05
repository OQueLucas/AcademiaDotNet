namespace AcademiaDotNet.ExerciciosSequenciais
{
    public class Exercicio2
    {
        // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
        public static void MediaAritmerica()
        {
            float valor1 = 5;
            float valor2 = 7;
            float valor3 = 7;
            float valor4 = 9;
            float media;

            media = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine($"A média dos valores é: {media}");
        }
    }
}
