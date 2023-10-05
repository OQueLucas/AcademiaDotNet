namespace AcademiaDotNet.ExerciciosSelecao
{
    internal class Exercicio14
    {
        // 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
        // link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
        // do arquivo usando este link(em minutos).

        public static void Download()
        {
            Console.WriteLine("Insira o tamanho do arquivo para download (em MB): ");
            float mb = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira  a velocidade do link de Internet (em Mbps): ");
            float mbps = float.Parse(Console.ReadLine());

            float tempo = mb / (mbps / 8);
            int minutos = (int)tempo / 60;

            Console.WriteLine($"O download levará aproximadamente {minutos} minutos.");
        }
    }
}
