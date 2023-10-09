namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio8
    {
        // 8. Faça um programa em VS que solicite um numero inteiro. S
        // e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
        // Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

        public static void InteiroParImpar()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("Insira um número inteiro: ");
                string numero = Console.ReadLine();

                if (int.TryParse(numero, out int valor))
                {
                    if (valor % 2 == 0)
                    {
                        Console.WriteLine("Número par!");
                    }
                    else
                    {
                        Console.WriteLine("Número impar!");
                    }
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Deseja continuar (s/n)?");
                char c = char.Parse(Console.ReadLine());

                if (c != 's')
                {
                    continuar = false;
                }


            } while (continuar);
        }
    }
}
