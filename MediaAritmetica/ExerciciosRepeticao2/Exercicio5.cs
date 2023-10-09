namespace AcademiaDotNet.ExerciciosRepeticao2
{
    internal class Exercicio5
    {
        // 5. Modifique o programa em VS anterior para aceitar votos nulos 
        // (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
        // Ao final, informe o nome do candidato vencedor, o número de votos nulos
        // e o número de pessoas que votaram.

        public static void Votacao()
        {
            string votacao = "INICIADA";
            int votosJoao = 0, votosZeca = 0, votosBranco = 0, votosNulos = 0;

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
                else if (votacao == "ZECA")
                {
                    votosZeca++;
                }
                else if (votacao == "BRANCO")
                {
                    votosBranco++;
                }
                else if (votacao != "FIM")
                {
                    votosNulos++;
                }
            }

            Console.WriteLine("Votos:");
            Console.WriteLine("JOAO \t | \t ZECA \t | \t BRANCO \t | \t NULOS");
            Console.WriteLine($"{votosJoao} \t | \t {votosZeca} \t | \t {votosBranco} \t | \t {votosNulos}");

            if (votosJoao > votosZeca)
            {
                Console.WriteLine("O candidato vencedor é João");
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine("O candidato vencedor é Zeca");
            }
        }
    }
}
