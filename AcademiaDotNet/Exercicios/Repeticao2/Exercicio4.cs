namespace AcademiaDotNet.Exercicios.Repeticao2
{
    internal class Exercicio4
    {
        // 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
        // Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
        // Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA.
        // Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário
        // escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
        // de votos em branco.

        public static void Votacao()
        {
            string votacao = "INICIADA";
            int votosJoao = 0, votosZeca = 0, votosBranco = 0;

            Console.WriteLine("JOAO \t ZECA \t BRANCO");
            Console.WriteLine("Digite FIM para encerrar \n");

            while (votacao != "FIM")
            {

                Console.WriteLine("Insira aqui seu voto: ");
                votacao = Console.ReadLine().ToUpper();

                if (votacao == "JOAO")
                {
                    votosJoao++;
                }
                if (votacao == "ZECA")
                {
                    votosZeca++;
                }
                if (votacao == "BRANCO")
                {
                    votosBranco++;
                }
            }

            Console.WriteLine("Votos:");
            Console.WriteLine("JOAO \t ZECA \t BRANCO");
            Console.WriteLine($"{votosJoao} \t {votosZeca} \t {votosBranco}");

        }
    }
}
