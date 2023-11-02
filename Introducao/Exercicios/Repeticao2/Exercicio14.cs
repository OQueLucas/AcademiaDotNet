namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio14
    {
        // 14. Mostrar as potências de 2 variando de 0 a 10.
        public static void Potencia()
        {
            for (int i = 0; i <= 10; i++)
            {
                int total = 2;
                int potencia = total;

                if (i == 0)
                {
                    total = 1;
                }
                else
                {
                    for (int j = 1; j < i; j++)
                    {
                        total *= potencia;
                    }
                }

                Console.Write($"{i}º laço: {total} resposta formula: " + Math.Pow(potencia, i));

                Console.WriteLine();

            }
        }
    }
}
