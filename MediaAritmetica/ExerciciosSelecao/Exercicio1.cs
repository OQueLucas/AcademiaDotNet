namespace AcademiaDotNet.ExerciciosSelecao
{
    class Exercicio1
    {
        // 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
        // Área do triangulo = (base * altura) / 2; 
        // Teste se a base ou a altura digitada não foi igual a zero.
        public static void areaTriangulo()
        {
            Console.WriteLine("Insira um valor inteiro para a base do triangulo: ");
            int baseTriangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor inteiro para a altura do triangulo: ");
            int alturaTriangulo = int.Parse(Console.ReadLine());

            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                Console.WriteLine($"A área do triangulo é: {areaTriangulo}");
            }
            else
            {
                Console.WriteLine("Os valores não podem ser 0");
            }
        }
    }
}
