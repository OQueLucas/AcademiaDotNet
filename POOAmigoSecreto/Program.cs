namespace POOAmigoSecreto
{
    internal class Program
    {
        static void Main()
        {
            string opcao;
            List<Pessoa> pessoas = new();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listagem de pessoa");
                Console.WriteLine("3 - Gerar amigo secreto");
                Console.WriteLine("4 - Sair");

                Console.Write("Opção: ");
                opcao = Console.ReadKey().KeyChar.ToString();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Cadastrar pessoa");
                        Comunicacao.Cadastrar(pessoas);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Listagem de pessoa");
                        Comunicacao.Listar(pessoas);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Gerar amigo secreto");
                        Comunicacao.GerarAmigoSecreto(pessoas);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != "4");
        }
    }
}