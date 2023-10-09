namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio17
    {
        // 17. Apresentar os quadrados dos números inteiros de 15 a 200.

        public static void QuadradosInteiros()
        {
            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine($"Quadrado de {i} é {i * i}");
            }
        }
    }
}
