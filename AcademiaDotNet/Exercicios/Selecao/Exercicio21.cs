namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio21
    {
        // 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
        // medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
        // valor para a unidade de saída selecionada.

        public static void Conversor()
        {
            float valorSaida = 0;

            Console.WriteLine("Escolha a unidade de medida de entrada: ");
            Console.WriteLine("1 - metros");
            Console.WriteLine("2 - centimetros");
            Console.WriteLine("3 - polegadas");
            Console.WriteLine("4 - pes");
            byte entrada = byte.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a unidade de medida de saída: ");
            Console.WriteLine("1 - metros");
            Console.WriteLine("2 - centimetros");
            Console.WriteLine("3 - polegadas");
            Console.WriteLine("4 - pes");
            byte saida = byte.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de entrada: ");
            float valorEntrada = float.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    switch (saida)
                    {
                        case 2:
                            valorSaida = valorEntrada * 100;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 39.37F;
                            break;
                        case 4:
                            valorSaida = valorEntrada * 3.281F;
                            break;
                        default:
                            Console.WriteLine("Saída invalida, escolha uma diferente da entrada.");
                            break;
                    }
                    break;
                case 2:
                    switch (saida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 100;
                            break;
                        case 3:
                            valorSaida = valorEntrada / 2.54F;
                            break;
                        case 4:
                            valorSaida = valorEntrada / 30.48F;
                            break;
                        default:
                            Console.WriteLine("Saída invalida, escolha uma diferente da entrada.");
                            break;
                    }
                    break;
                case 3:
                    switch (saida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 39.37F;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 2.54F;
                            break;
                        case 4:
                            valorSaida = valorEntrada / 12;
                            break;
                        default:
                            Console.WriteLine("Saída invalida, escolha uma diferente da entrada.");
                            break;
                    }
                    break;
                case 4:
                    switch (saida)
                    {
                        case 1:
                            valorSaida = valorEntrada / 3.281F;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 30.48F;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 12;
                            break;
                        default:
                            Console.WriteLine("Saída invalida, escolha uma diferente da entrada.");
                            break;
                    }
                    break;
            }
            Console.WriteLine(valorSaida);
        }
    }
}
