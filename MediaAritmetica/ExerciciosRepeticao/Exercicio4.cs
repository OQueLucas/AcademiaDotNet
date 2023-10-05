namespace AcademiaDotNet.ExerciciosRepeticao
{
    internal class Exercicio4
    {
        // 4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
        // elevado na y sem utilizar a função pow.

        public static void Potencia()
        {
            Console.WriteLine("Digite o valor x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor y");
            int y = int.Parse(Console.ReadLine());

            //int x = 5, y = 3;

            int potencia = x;

            for (int i = 1; i < y; i++)
            {
                x = x * potencia;
            }

            Console.WriteLine(x);
        }
    }
}
