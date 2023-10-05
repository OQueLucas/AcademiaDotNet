namespace AcademiaDotNet.ExerciciosSelecao
{
    internal class Exercicio17
    {
        // 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
        // formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados.Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
        // os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

        public static void Triangulo()
        {
            Console.WriteLine("Insira o tamanho do lado a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tamanho do lado b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tamanho do lado c: ");
            int c = int.Parse(Console.ReadLine());

            if (a <= b + c && b <= a + c && c <= a + b)
            {
                if (a == b && a == c)
                {
                    Console.WriteLine("É um triângulo equilátero");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("É um triângulo isoceles");
                }
                else if (a != b && b != c && a != c)
                {
                    Console.WriteLine("É um triângulo escaleno");
                }

            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo");
            }
        }
    }
}
