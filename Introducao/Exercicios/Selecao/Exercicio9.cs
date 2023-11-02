namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio9
    {
        // 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
        // diária de um paciente diabético.Para cada valor recebido analisar e informar ao paciente o seguinte:
        // Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
        // Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

        // Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
        // menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
        // 150, avisá-lo que será necessário adicionar 2 unidades de insulina.

        public static void TesteGlicemia()
        {
            float teste;
            float total = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Insira o valor do {i}º teste de glicemia em jejum: ");
                teste = float.Parse(Console.ReadLine());

                if (teste < 65)
                {
                    Console.WriteLine("Corre risco de hipoglicemia.\n");
                }
                else if (teste > 250)
                {

                    Console.WriteLine("Corre risco de hiperglicemia.\n");
                }

                total += teste;
            }

            float media = total / 3;
            Console.WriteLine($"Média da glicemia: {media}.");

            if (media < 80)
            {
                Console.WriteLine("É preciso diminuir 2 unidades de insulina.");
            }
            else if (media > 150)
            {
                Console.WriteLine("É necessário adicionar 2 unidades de insulina.");
            }


        }
    }
}
