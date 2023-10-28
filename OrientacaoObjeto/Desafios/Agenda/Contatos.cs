namespace OrientacaoObjeto.Desafios.Agenda
{
    internal class Contatos
    {
        // 4 - Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail).
        // Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.

        List<AgendaTelefonica> contatos = new();

        public void AdicionarContato(string nome, string telefone, string email)
        {
            contatos.Add(new(nome, telefone, email));
        }

        public void CadastrarContato()
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o numero de telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Insira o email: ");
            string email = Console.ReadLine();

            AdicionarContato(nome, telefone, email);
        }

        public void RemoverContato(string nome)
        {
            var contato = contatos.Find(contato => contato.nome.Contains(nome));

            if (contato == null)
            {
                Console.WriteLine("Contato não encontrado");
            }
            else
            {
                contatos.Remove(contato);
            }
        }

        public void ExcluirContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja remover: ");
            string nome = Console.ReadLine();

            RemoverContato(nome);
        }

        public void BuscarContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja buscar: ");
            string nome = Console.ReadLine();

            AgendaTelefonica contato = contatos.Find(contato => contato.nome.Contains(nome));

            if (contato == null)
            {
                Console.WriteLine("Contato não encontrado");
            }
            else
            {
                Console.WriteLine(contato);
            }
        }

        private void ListarContatos()
        {
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
        }

        public void Menu()
        {
            byte opcao;
            do
            {
                Console.WriteLine("Selecione o que deseja fazer: (1 - Adicionar contato / 2 - Remover contato / 3 - Buscar contato / 4 - Listar Contatos / 5 - Sair)");
                Console.Write("Opção: ");
                opcao = byte.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CadastrarContato();
                        break;
                    case 2:
                        ExcluirContato();
                        break;
                    case 3:
                        BuscarContato();
                        break;
                    case 4:
                        ListarContatos();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (opcao != 5);
        }
    }
}
