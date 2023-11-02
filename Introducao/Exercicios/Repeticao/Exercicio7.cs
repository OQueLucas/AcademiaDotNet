namespace Introducao.Exercicios.Repeticao
{
    internal class Exercicio7
    {
        // 7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
        // um usuário.Apresente o resultado.

        public static void Contador()
        {
            int par = 0;
            int impar = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Digite o valor {i}");
                int valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine($"Foi digitado {par} numeros pares");
            Console.WriteLine($"Foi digitado {impar} numeros impares");
        }
    }
}
