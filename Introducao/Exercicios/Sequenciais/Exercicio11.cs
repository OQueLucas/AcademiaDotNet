namespace Introducao.Exercicios.Sequenciais
{
    internal class Exercicio11
    {
        // 11) Escreva um algoritmo para ler o número de eleitores de um município,
        // o número de votos brancos, nulos e válidos.
        // Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.
        public static void PercentualVotos()
        {
            Console.WriteLine("Insira o numero de votos brancos: ");
            int brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de votos nulos: ");
            int nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            int total = brancos + nulos + validos;
            float percentualBranco = ((float)brancos / (float)total) * 100;
            float percentualNulo = ((float)nulos / (float)total) * 100;
            float percentualValido = ((float)validos / (float)total) * 100;

            Console.WriteLine($"O percentual de votos brancos foi de {percentualBranco.ToString("F2")}%");
            Console.WriteLine($"O percentual de votos nulos foi de {percentualNulo.ToString("F2")}%");
            Console.WriteLine($"O percentual de votos validos foi de {percentualValido.ToString("F2")}%");
        }
    }
}
