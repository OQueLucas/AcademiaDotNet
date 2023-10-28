namespace OrientacaoObjeto.Desafios.GerenciamentoDeTarefas
{
    internal class Tarefa
    {
        // 5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento).
        // Implemente um construtor e métodos para adicionar, remover e listar tarefas. Adicione um método para verificar se a nome deverá ser executada no dia de hoje. 

        public string nome;
        public string descricao;
        public DateTime dataDeVencimento;

        public Tarefa(string nome, string descricao, DateTime dataDeVencimento)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.dataDeVencimento = dataDeVencimento;
        }

        public override string ToString()
        {
            return nome + " - " + descricao + " - " + dataDeVencimento.ToString();
        }
    }
}
