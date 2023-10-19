namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio2
    {
        // 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
        public static void verificaPar()
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine($"O valor {valor} é par.");
            }
            else
            {
                Console.WriteLine($"O valor {valor} é impar.");

            }
        }
    }
}
