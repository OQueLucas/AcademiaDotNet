namespace Introducao.Exercicios.Repeticao
{
    internal class Exercicio3
    {
        // 3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
        // x lido utilizando laços de repetição, e mostre na tela.

        public static void Tabuada()
        {
            Console.WriteLine("Insira o valor para a tabuada: ");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} x {i} = {valor * i}");
            }
        }
    }
}
