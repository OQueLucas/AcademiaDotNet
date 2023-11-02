namespace Introducao.Exercicios.Vetores
{
    internal class Exercicio12
    {
        // 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo
        // usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

        public static void VerificaN()
        {
            int[] v = new int[10];
            int cont = 0;
            Random rnd = new();

            for (int i = 0; i < v.Length; i++)
            {
                //Console.Write($"Insira o {i + 1}º valor do vetor: ");
                v[i] = rnd.Next(10);
                //v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" | ", v));

            Console.Write($"Digite o valor você deseja achar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == n)
                {
                    int valor = Array.IndexOf(v, v[i]);
                    Console.Write(valor + "\t");
                }
                else
                {
                    cont++;
                }
            }
            if (v.Length == cont)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
        }
    }
}
