namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio1
    {
        // 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
        // (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
        // Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

        // Exemplo:
        // Digite um número inteiro positivo: -8
        // Valor incorreto!
        // Digite um número inteiro positivo: 8
        // Numero digitado: 8
        // Números inteiros pares entre 1 e 8: 2, 4, 6.

        public static void NumeroPositivo()
        {
            int numero;
            do
            {
                Console.WriteLine("Insira um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Numero informado não é positivo!");
                    Console.WriteLine();
                    continue;
                }
            } while (numero <= 0);


            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
