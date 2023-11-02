namespace Introducao.Exercicios.Funcoes
{
    internal class Exercicio2
    {
        // 2) Fazer programa que tenha duas funções.
        // i) para ler um vetor de 10 elementos (variável global) e [
        // ii) para verificar e apresentar a quantidade de elementos pares que este vetor possui.

        public static double[] LerVetor()
        {
            double[] vetor = new double[10];
            for (int i = 0; i < vetor.Length;  i++)
            {
                Console.Write($"{i + 1}: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            return vetor;
        }

        public static void VerificaPar(double[] vetor)
        {
            foreach (var v in vetor)
            {
                if (v % 2 == 0)
                    Console.WriteLine($"{v} é Par!");
                else
                    Console.WriteLine($"{v} é Impar!");
            }
        }
    }
}
