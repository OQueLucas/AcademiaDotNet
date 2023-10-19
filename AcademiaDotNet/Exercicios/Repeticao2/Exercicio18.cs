namespace AcademiaDotNet.Exercicios.Repeticao2
{
    internal class Exercicio18
    {
        // 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
        // elevada a um expoente qualquer, ou seja, NM.

        public static void Potencia()
        {
            Console.WriteLine("Digite o valor m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor n");
            int n = int.Parse(Console.ReadLine());

            //int m = 5, n = 3;
            Console.WriteLine();
            Potenciacao(m, n);
            Console.WriteLine();
            Console.WriteLine(Math.Pow(m, n)); ;


        }

        public static void Potenciacao(int m, int n)
        {
            int potencia = m;

            for (int i = 1; i < n; i++)
            {
                m = m * potencia;
            }

            Console.WriteLine(m);
        }
    }
}
