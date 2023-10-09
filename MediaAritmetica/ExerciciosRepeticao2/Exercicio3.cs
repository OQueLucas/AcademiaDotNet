namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio3
    {
        // 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
        // Se o usuário digitar 0 o programa em VS deve parar.
        // Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

        public static void Loop()
        {
            int numero;
            do
            {
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Esse número é par!");
                }
                else
                {
                    Console.WriteLine("Esse número é impar!");
                }

                if ((numero == 2 || numero == 3 || numero == 5 || numero == 7) || (numero > 1 && numero % 2 != 0 && numero % 3 != 0 && numero % 4 != 0 && numero % 5 != 0 && numero % 6 != 0 && numero % 7 != 0))
                {
                    Console.WriteLine("É numero primo");

                }

            } while (numero != 0);
        }
    }
}
