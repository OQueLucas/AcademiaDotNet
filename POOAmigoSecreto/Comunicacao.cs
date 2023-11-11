namespace POOAmigoSecreto
{
    internal class Comunicacao
    {
        public static void Cadastrar(List<Pessoa> pessoas)
        {
            string op = "S";

            do
            {
                Console.WriteLine("Digite o email: ");
                string email = Console.ReadLine();

                if (string.IsNullOrEmpty(email) || !Utilidades.EmailIsValid(email))
                {
                    Console.WriteLine("Informe um email válido");
                    continue;
                }

                Console.WriteLine("Digite o nome ou sair:");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }
                else if (name == "sair")
                {
                    break;
                }

                Pessoa pessoa = new(name, email);

                if(pessoas.Contains(pessoa))
                {
                    Console.WriteLine("Email já em uso!");
                }
                else
                {
                    pessoas.Add(new Pessoa(name, email));
                    pessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                    Persistencia.CSVWriter(pessoa);
                }

                Console.WriteLine("Tecle S se deseja sair: ");
                op = Console.ReadKey().KeyChar.ToString();

            } while (op.ToUpper() != "S");
        }

        public static void Listar(List<Pessoa> pessoas)
        {
            Persistencia.CSVReader(pessoas);

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p);
            }
        }

        public static void GerarAmigoSecreto(List<Pessoa> pessoas)
        {
            try
            {
                Persistencia.CSVReader(pessoas);

                Random rng = new();

                List<Pessoa> listPessoas = pessoas.OrderBy(a => rng.Next()).ToList();

                List<Pessoa> listAmigos = listPessoas.ToList();

                List<AmigoSecreto> listAmigosSecretos = new();

                foreach (Pessoa pessoa in listPessoas)
                {
                    int random = rng.Next(0, listAmigos.Count);
                    Pessoa amigo = listAmigos.ElementAt(random);

                    if (pessoa != amigo)
                    {
                        listAmigosSecretos.Add(new(pessoa, amigo));
                        listAmigos.Remove(amigo);
                    }
                    else
                    {
                        throw new Exception("Gere novamente, alguém tirou a si mesmo");
                    }
                }

                Persistencia.CSVWriter(listAmigosSecretos);

                Console.WriteLine("Lista gerada com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
