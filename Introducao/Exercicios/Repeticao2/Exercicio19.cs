namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio19
    {
        // 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
        // coletando dados sobre o salário e número de filhos.A prefeitura deseja saber: 

        // a) média do salário da população;
        // b) média do número de filhos;
        // c) maior salário;
        // d) percentual de pessoas com salário até R$ 100,00.
        // O final da leitura de dados se dará com a entrada de um salário negativo.

        public static void IBGE()
        {
            float salario, totalSalario = 0, mediaSalario, maiorSalario = 0, percentualSalarioAte100;
            int filhos, totalFilhos = 0, mediaFilhos, totalHabitantes = 0, salarioAte100 = 0;


            while (true)
            {
                Console.Write("Digite o salário do habitante: ");
                salario = float.Parse(Console.ReadLine());

                if (salario <= 0) break;

                Console.Write("Digite o numero de filhos do habitante: ");
                filhos = int.Parse(Console.ReadLine());

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario < 100)
                {
                    salarioAte100++;
                }

                totalHabitantes++;
                totalSalario += salario;
                totalFilhos += filhos;
            }

            mediaFilhos = totalFilhos / totalHabitantes;
            mediaSalario = totalSalario / totalHabitantes;
            percentualSalarioAte100 = (float)salarioAte100 / (float)totalHabitantes * (float)100;

            Console.WriteLine();
            Console.WriteLine($"A média do salário é de R$ {mediaSalario}.");
            Console.WriteLine($"A média de numero de filhos é de R$ {mediaFilhos}.");
            Console.WriteLine($"O maior salário é R$ {maiorSalario}.");
            Console.WriteLine($"O percentual de salário até 100 é de {percentualSalarioAte100.ToString("F2")}%.");
        }
    }
}
