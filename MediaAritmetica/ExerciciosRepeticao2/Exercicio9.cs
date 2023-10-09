using System;

namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio9
    {
        // 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
        // o zoológico num determinado dia, imprimindo:
        // Quantas pessoas tem entre 1 e 3 filhos.
        // Quantas pessoas tem entre 4 e 7 filhos.
        // Quantas pessoas tem mais de 8 filhos.
        // Quantas pessoas não tem filhos.

        public static void QteFilhos()
        {
            int entre1e3 = 0, entre4e7 = 0, mais8 = 0, nenhum = 0;

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"Insira a quantidade de filhos do visitante {i}: ");
                int qtdFilhos = int.Parse(Console.ReadLine());

                if (qtdFilhos >= 1 && qtdFilhos <= 3)
                {
                    entre1e3++;
                }
                else if (qtdFilhos >= 4 && qtdFilhos <= 7)
                {
                    entre4e7++;
                }
                else if (qtdFilhos >= 8)
                {
                    mais8++;
                }
                else
                {
                    nenhum++;
                }
            }

            Console.WriteLine($"{entre1e3} pessoas entre 1 e 3 filhos.");
            Console.WriteLine($"{entre4e7} pessoas entre 4 e 8 filhos.");
            Console.WriteLine($"{mais8} pessoas com mais de 8 filhos.");
            Console.WriteLine($"{nenhum} pessoas com nenum filhos.");
        }
    }
}
