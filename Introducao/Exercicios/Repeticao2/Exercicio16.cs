namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio16
    {
        // 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
        // multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
        // (N*3; N*3*3; N*3*3*3; etc).

        public static void Multiplicacao()
        {
            int n;
            int produto;
            int j = 1;

            Console.WriteLine("Digite um valor igual ou menor a 50: ");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n > 50);

            do
            {
                produto = n;
                int potencia = 3;
                for (int i = 1; i <= j; i++)
                {
                    produto *= potencia;
                }
                j++;

                if (produto < 250)
                {
                    Console.WriteLine(produto);
                }
            } while (produto < 250);
        }
    }
}
