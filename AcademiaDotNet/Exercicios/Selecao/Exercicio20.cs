namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio20
    {
        // 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
        // plus: você pode gerar o número de forma randomica(função random c#).

        public static void Adivinhe()
        {
            byte numero = 0;
            var random = new Random();
            byte tentativas = 3;

            byte numeroRandom = (byte)random.Next();
            random.Next();

            do
            {
                Console.WriteLine($"Tentativas restantes: {tentativas}");

                Console.WriteLine("Tente adivinhar o número: ");
                numero = byte.Parse(Console.ReadLine());

                if (numeroRandom > numero)
                {
                    Console.WriteLine("É maior");
                }
                if (numeroRandom < numero)
                {
                    Console.WriteLine("É menor");
                }
                if (numeroRandom == numero)
                {

                    Console.WriteLine("Parabéns! Você ganhou!");
                }

                tentativas--;
                Console.WriteLine();
            } while (numero != numeroRandom && tentativas > 0);

            if (tentativas == 0 && numeroRandom != numero)
            {
                Console.WriteLine("Tentativas encerradas");
            }
        }
    }
}
