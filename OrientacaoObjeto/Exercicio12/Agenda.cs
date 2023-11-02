using System.Globalization;

namespace OrientacaoObjeto.Exercicio12
{
    internal class Agenda
    {
        // 12 - Crie uma classe Pessoa que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
        // void armazenaPessoa(String nome, int idade, float altura);
        // void removePessoa(String nome);
        // Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
        // void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
        // Faça um menu para navegar entre as opções infinitamente.

        List<Pessoa> list;

        public Agenda()
        {
            list = new();
        }

        public void CadastrarPessoa()
        {
            Console.Write("Insira o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Insira a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Insira a altura da pessoa: ");
            float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ArmazenaPessoa(nome, idade, altura);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            list.Add(new(nome, idade, altura));
        }

        public void RemoverPessoa()
        {
            Console.Write("Insira o nome da pessoa: ");
            string nome = Console.ReadLine();
            RemovePessoa(nome);
        }

        public void RemovePessoa(string nome)
        {
            var pessoa = BuscaPessoa(nome);
            list.Remove(pessoa);
        }

        public Pessoa BuscaPessoa(string nome)
        {
            var pessoa = list.FirstOrDefault(p => p.Nome == nome);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada!");
                return null;
            }

            return pessoa;
        }

        public void ImprimeAgenda()
        {
            foreach (var agenda in list)
            {
                Console.WriteLine(agenda);
            }
        }

        public void AgendaApp()
        {
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("****AGENDA****");
                    Console.WriteLine();
                    Console.WriteLine("1 - Cadastrar pessoa");
                    Console.WriteLine("2 - Imprimir pessoas cadastradas");
                    Console.WriteLine("3 - Remover pessoa cadastrada");
                    Console.WriteLine();
                    Console.WriteLine("Digite o numero da operação que deseja realizar: ");
                    Console.Write("> ");
                    char opcao = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (opcao)
                    {
                        case '1':
                            CadastrarPessoa();
                            break;
                        case '2':
                            ImprimeAgenda();
                            break;
                        case '3':
                            RemoverPessoa();
                            break;
                        default:
                            Console.WriteLine("Valor informado não disponível.");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Pressione N para encerrar a operação: ");
                    Console.Write("> ");
                    string input = Console.ReadKey().Key.ToString().ToUpper();

                    if (input == "N")
                    {
                        continuar = false;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (continuar);
        }
    }
}
