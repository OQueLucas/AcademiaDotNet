namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio11
    {
        // 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
        // O programa deve exibir se a hora digitada está ou não válida.
        // Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

        public static void Hora()
        {
            Console.WriteLine("Digite a hora (hh:mm): ");
            string horaCompleta = Console.ReadLine();

            string[] horaSplit = horaCompleta.Split(':');
            int hora = int.Parse(horaSplit[0]);
            int minuto = int.Parse(horaSplit[1]);

            if (hora < 0 || hora > 23)
            {
                Console.WriteLine("Hora digitada inválida.");
            }
            else if (minuto < 0 || minuto > 59)
            {
                Console.WriteLine("Minuto digitada inválido.");
            }
            else
            {

                Console.WriteLine("válido.");
            }

        }
    }
}
