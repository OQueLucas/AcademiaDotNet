namespace AcademiaDotNet.Exercicios.Funcoes
{
    internal class Exercicio7
    {
        // 7) Crie uma função que determine se um número é primo ou não.

        public static void Primo()
        {
            int valor = 97;
            int count = 0;

            for (int i = 1; i < valor; i++)
            {
                if (valor % i == 0)
                {
                    count++;
                }
                if (count > 1)
                {
                    Console.WriteLine("Não é primo!");
                    break;
                } else if (i + 1 == valor && count == 1)
                {
                    Console.WriteLine("É primo!");
                }
            }
        }
    }
}
