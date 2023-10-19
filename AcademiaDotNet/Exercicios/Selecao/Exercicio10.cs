namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio10
    {
        // 10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
        // O programa deve mostrar os dados do atleta mais novo e mais alto.

        public static void Atletas()
        {
            Console.WriteLine("Nome: ");
            string nomeA = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idadeA = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            float alturaA = float.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string nomeB = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idadeB = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            float alturaB = float.Parse(Console.ReadLine());

            if (idadeA > idadeB)
            {
                Console.WriteLine($"Atleta {nomeA} é mais velho que Atleta {nomeB}");
            }
            else if (idadeB > idadeA)
            {
                Console.WriteLine($"Atleta {nomeB} é mais velho que Atleta {nomeA}");
            }
            else
            {
                Console.WriteLine("Os dois possuem a mesma idade");
            }

            if (alturaA > alturaB)
            {
                Console.WriteLine($"Atleta {nomeA} é maior que Atleta {nomeB}");
            }
            else if (alturaB > alturaA)
            {
                Console.WriteLine($"Atleta {nomeB} é maior que Atleta {nomeA}");
            }
            else
            {
                Console.WriteLine("Os dois possuem a mesma altura");
            }
        }
    }
}
