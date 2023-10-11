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

                int cont = 0;

                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 1)
                {
                    Console.WriteLine("É numero primo");
                }

            } while (numero != 0);
        }
    }
}
