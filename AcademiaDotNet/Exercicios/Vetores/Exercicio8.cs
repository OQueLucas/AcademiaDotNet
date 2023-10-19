using System;

namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio8
    {
        // 8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.Exemplo:
        // a.lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
        // b.escreve: 	|3|5|6|7|9|10|14|. . .

        public static void MenorZero()
        {
            double[] a = new double[30];
            Random rnd = new();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (float)(float.MaxValue * 2.0 * (rnd.NextDouble() - 0.5));

                if (a[i] < 0)
                {
                    Console.Write(Array.IndexOf(a, a[i]) + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" | ", a));
        }
    }
}
