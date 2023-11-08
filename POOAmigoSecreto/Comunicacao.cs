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
    }
}
