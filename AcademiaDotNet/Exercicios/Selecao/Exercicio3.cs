namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio3
    {
        // 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
        public static void mediaMaiorNota()
        {
            int[] valor = new int[4];
            int soma;
            double media;

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Insira o valor {i + 1}: ");
                valor[i] = int.Parse(Console.ReadLine());
            }
            soma = valor.Sum();

            media = soma / 4;
            Console.WriteLine($"A média é {media}");
            Console.WriteLine();
            Console.WriteLine("E os valores acima da média são: ");

            foreach (var item in valor)
            {
                if (item > media)
                {
                    Console.Write($"{item} ");
                }
            }

        }
    }
}
