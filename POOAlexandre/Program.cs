namespace POOAlexandre
{
    internal class Program
    {
        static void Main()
        {
            List<Atleta> listaAtletas = new();
            List<Treinador> listaTreinadores = new();
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar atleta");
                Console.WriteLine("2 - Listar atletas");
                Console.WriteLine("3 - Remover atleta");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Cadastro de atleta");
                        Comunicacao.CadastrarAtleta(listaAtletas);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Listagem de atletas");
                        Comunicacao.ListarAtletas(listaAtletas);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Remoção de atleta");
                        Comunicacao.RemoverAtleta(listaAtletas);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Cadastro de atleta");
                        Comunicacao.CadastrarTreinador(listaTreinadores);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Listagem de atletas");
                        Comunicacao.ListarTreinadores(listaTreinadores);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Remoção de atleta");
                        Comunicacao.RemoverTreinador(listaTreinadores);
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
            } while (opcao != "7");
        }
    }
}