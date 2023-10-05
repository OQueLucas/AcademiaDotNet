namespace AcademiaDotNet.ExerciciosSequenciais
{
    public class Exercicio1
    {
        // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
        public static void MediaAritmetica()
        {
            float valor1 = 5;
            float valor2 = 7;
            float media;

            media = (valor1 + valor2) / 2;

            Console.WriteLine($"A média dos valores é: {media}");
        }
    }
}
