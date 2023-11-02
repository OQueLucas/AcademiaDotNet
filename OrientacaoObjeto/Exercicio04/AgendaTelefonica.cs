namespace OrientacaoObjeto.Exercicio04
{
    internal class AgendaTelefonica
    {
        // 4 - Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail).
        // Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.

        public string nome;
        public string telefone;
        public string email;

        public AgendaTelefonica(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public override string ToString()
        {
            return "Nome: " + nome
                + "\tTelefone: " + telefone
                + "\tEmail: " + email;
        }
    }
}
