namespace AcademiaDotNet.Exercicios.Funcoes
{
    internal class Exercicio6
    {
        // 6) Escreva uma função que calcule a média de um vetor de 10 números.

        public static void MediaVetor()
        {
            double[] vetor = new double[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            double total = 0;

            foreach (double v in vetor)
            {
                total += v;
            }

            double media = total / vetor.Length;

            Console.WriteLine(media);
        }
    }
}