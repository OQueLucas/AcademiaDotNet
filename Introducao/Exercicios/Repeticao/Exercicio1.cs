namespace Introducao.Exercicios.Repeticao
{
    internal class Exercicio1
    {
        // 1. Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
        // pessoas e calcular a média das idades.

        public static void MediaIdades()
        {
            int total = 0;
            Console.WriteLine("Insira a quantidade de idades a ser digitada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insira a idade {i + 1}");
                int idade = int.Parse(Console.ReadLine());

                total = total + idade;
            }
            int media = total / n;

            Console.WriteLine($"A media da idade é {media}");
        }
    }
}
