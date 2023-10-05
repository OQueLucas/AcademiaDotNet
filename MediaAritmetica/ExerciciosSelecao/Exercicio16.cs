namespace AcademiaDotNet.ExerciciosSelecao
{
    internal class Exercicio16
    {
        // 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
        // na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.Caso contrário, mostre uma mensagem indicando que os dois times irão se
        // enfrentar novamente em um novo jogo.
        // ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
        // ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
        // plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

        public static void Placar()
        {
            Console.WriteLine("Insira a quantidade de gols do time da casa: ");
            int golsCasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de gols do time de fora: ");
            int golsFora = int.Parse(Console.ReadLine());

            int saldoGolFora = golsFora - golsCasa;

            if (saldoGolFora >= 2)
            {
                Console.WriteLine("O time de fora já se classificou");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo");

                Console.WriteLine("Insira a quantidade de gols do time da casa: ");
                int golsCasa2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade de gols do time de fora: ");
                int golsFora2 = int.Parse(Console.ReadLine());

                int totalGolCasa = golsCasa + golsCasa2;
                int totalGolFora = golsFora + golsFora2;

                if (totalGolCasa > totalGolFora)
                {
                    Console.WriteLine("O time de casa se classificou");
                }
                else if (totalGolFora > totalGolCasa)
                {
                    Console.WriteLine("O time de fora se classificou");

                }
            }
        }
    }
}
