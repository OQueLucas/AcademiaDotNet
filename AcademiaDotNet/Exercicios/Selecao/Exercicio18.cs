namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio18
    {
        // 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
        public static void Maior()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("Primeiro valor é o maior!");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("Segundo valor é o maior!");
            }
            else if (valor3 > valor2 && valor3 > valor1)
            {
                Console.WriteLine("Terceiro valor é o maior!");
            }
            else
            {
                Console.WriteLine("Não possui valor maior!");
            }
        }
    }
}
