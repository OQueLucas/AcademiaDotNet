namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio15
    {
        // 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
        // ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
        // Considerar nota 7,0 como mínima para aprovação.

        public static void Aprovacao()
        {
            float[] notas = new float[4];
            float[] peso = { 2, 1, 2, 4 };
            float total = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Insira a {i + 1}ª nota do aluno: ");
                notas[i] = float.Parse(Console.ReadLine());
                total += notas[i] * peso[i];
                Console.WriteLine(total);
            }

            float media = total / 9;

            Console.WriteLine(media.ToString("F2"));

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
