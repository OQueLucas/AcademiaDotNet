namespace OrientacaoObjeto.Exercicio05
{
    internal class GerenciadorDeTarefas
    {
        // 5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento).
        // Implemente um construtor e métodos para adicionar, remover e listar tarefas. Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje. 

        List<Tarefa> tarefas = new();
        List<Tarefa> tarefasHoje = new();

        public void AdicionarTarefa(string tarefa, string descricao, DateTime dataDeVencimento)
        {
            tarefas.Add(new(tarefa, descricao, dataDeVencimento));
        }

        public void CadastrarTarefa()
        {
            Console.Write("Tarefa: ");
            string nome = Console.ReadLine();
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Data de vencimento: ");
            DateTime dataDeVencimento = DateTime.Parse(Console.ReadLine());

            AdicionarTarefa(nome, descricao, dataDeVencimento);
        }

        public void RemoverTarefa(string nome)
        {
            Tarefa tarefa = tarefas.Find(tarefa => tarefa.nome.Equals(nome));

            if (tarefa == null)
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
            else
            {
                tarefas.Remove(tarefa);
            }
        }

        public void ExcluirTarefa()
        {
            Console.WriteLine("Qual tarefa deseja excluir? ");
            string nome = Console.ReadLine();

            RemoverTarefa(nome);
        }

        public void ListarTarefas()
        {
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

        public void TarefasHoje()
        {
            tarefasHoje = tarefas.FindAll(tarefa => tarefa.dataDeVencimento <= DateTime.Now);

            foreach (var tarefa in tarefasHoje)
            {
                Console.WriteLine(tarefa);
            }
        }
    }
}
