namespace AcademiaDotNet.Exercicios.Repeticao2
{
    internal class Exercicio2
    {
        // 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
        // informar um outro número.Caso positivo, o programa em VS deve ser repetido.

        // Exemplo:
        // Digite um número inteiro positivo: 8
        // Numero digitado: 8
        // Números inteiros pares entre 1 e 8: 2, 4, 6.


        // Deseja informar outro número (s/n)? S

        // Digite um número inteiro positivo: 12
        // Numero digitado: 20
        // Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

        // Deseja informar outro número(s/n)? N

        public static void RepetirNumeroPositivo()
        {
            char c;
            do
            {
                Exercicio1.NumeroPositivo();

                Console.Write("Deseja informar outro número (s/n)?");
                c = char.Parse(Console.ReadLine());

            } while (c == 's');
        }
    }
}
