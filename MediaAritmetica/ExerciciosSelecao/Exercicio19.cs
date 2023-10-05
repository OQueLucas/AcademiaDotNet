namespace AcademiaDotNet.ExerciciosSelecao
{
    internal class Exercicio19
    {
        // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
        public static void Maior()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                if (valor2 > valor3)
                {
                    Console.WriteLine($"{valor3}, {valor2}, {valor1}");
                }
                else if (valor3 > valor2)
                {
                    Console.WriteLine($"{valor2}, {valor3}, {valor1}");
                }
            }
            else if (valor2 > valor1)
            {
                if (valor1 > valor3)
                {
                    Console.WriteLine($"{valor3}, {valor1}, {valor2}");
                }
                else if (valor3 > valor1)
                {
                    Console.WriteLine($"{valor1}, {valor3}, {valor2}");
                }
            }
            else if (valor3 > valor2)
            {
                if (valor2 > valor1)
                {
                    Console.WriteLine($"{valor1}, {valor2}, {valor3}");
                }
                else if (valor1 > valor2)
                {
                    Console.WriteLine($"{valor2}, {valor1}, {valor3}");
                }
            }
        }
    }
}
