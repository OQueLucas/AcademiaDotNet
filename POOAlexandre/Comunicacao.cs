namespace POOAlexandre
{
    internal class Comunicacao
    {

        public static void CadastrarAtleta(List<Atleta> lista)
        {
            string nome;
            string email;
            DateOnly dataNascimento;
            string posicao;
            string categoria;

            do
            {
                Console.Write("Informe um email válido: ");
                email = Console.ReadLine();
            } while (!Utilidades.EmailIsValid(email));

            if (Pessoa.EstaContido(email, lista))
            {
                Console.WriteLine("Email já utilizado no sistema!!");
            }
            else
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();

                bool dataValida = false;
                do
                {
                    try
                    {
                        Console.Write("Data nascimento [dd/mm/aaaa]: ");
                        dataValida = DateOnly.TryParse(Console.ReadLine(), out dataNascimento);

                        if (!dataValida)
                        {
                            throw new Exception("Data inválida");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (dataValida == false);

                Console.Write("Posição na quadra [direita ou esquerda]: ");
                posicao = Console.ReadLine().ToUpper();

                Console.Write("Categoria [1 ou 2 ou 3 ou 4 ou 5]: ");
                categoria = Console.ReadLine();

                Atleta atleta = new(nome, email, dataNascimento, posicao, categoria);

                lista.Add(atleta);
            }
        }
        public static void CadastrarTreinador(List<Treinador> lista)
        {
            string nome;
            string email;
            DateOnly dataNascimento;
            string registroConselho;
            string clube;

            do
            {
                Console.Write("Informe um email válido: ");
                email = Console.ReadLine();
            } while (!Utilidades.EmailIsValid(email));

            if (Pessoa.EstaContido(email, lista))
            {
                Console.WriteLine("Email já utilizado no sistema!!");
            }
            else
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();

                bool dataValida = false;
                do
                {
                    try
                    {
                        Console.Write("Data nascimento [dd/mm/aaaa]: ");
                        dataValida = DateOnly.TryParse(Console.ReadLine(), out dataNascimento);

                        if (!dataValida)
                        {
                            throw new Exception("Data inválida");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (dataValida == false);

                Console.Write("Registro do conselho: ");
                registroConselho = Console.ReadLine().ToUpper();

                Console.Write("Clube: ");
                clube = Console.ReadLine();

                Treinador treinador = new(nome, email, dataNascimento, registroConselho, clube);

                lista.Add(treinador);
            }
        }

        public static void ListarAtletas(List<Atleta> lista)
        {
            foreach (var atleta in lista)
            {
                Console.WriteLine("Atleta: " + atleta.Sobrenome + ". Idade: " + atleta.Idade + ". Posição: " + atleta.PosicaoQuadra + ". Categoria: " + atleta.Categoria);
            }
        }

        public static void ListarTreinadores(List<Treinador> lista)
        {
            foreach (var treinador in lista)
            {
                Console.WriteLine("Treinador: " + treinador.Sobrenome + ". Idade: " + treinador.Idade + ". Registro do conselho: " + treinador.RegistroConselho + ". Clube: " + treinador.Clube);
            }
        }

        public static void RemoverAtleta(List<Atleta> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
                return;
            }

            string pesquisa;
            Console.Write("Informe parte do nome ou o email: ");
            pesquisa = Console.ReadLine();

            Atleta? atleta = lista.Find(atleta => atleta.Nome.Contains(pesquisa) || atleta.Email.Contains(pesquisa));
            if (atleta != null)
            {
                Console.WriteLine("Atleta localizado: " + atleta.Nome);
                lista.Remove(atleta);
                Console.WriteLine("Removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Atleta não localizado!");
            }
        }
        public static void RemoverTreinador(List<Treinador> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
                return;
            }

            string pesquisa;
            Console.Write("Informe parte do nome ou o email: ");
            pesquisa = Console.ReadLine();

            Treinador? treinador = lista.Find(treinador => treinador.Nome.Contains(pesquisa) || treinador.Email.Contains(pesquisa));
            if (treinador != null)
            {
                Console.WriteLine("Treinador localizado: " + treinador.Nome);
                lista.Remove(treinador);
                Console.WriteLine("Removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Treinador não localizado!");
            }
        }
    }
}
