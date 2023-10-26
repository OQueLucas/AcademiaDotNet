namespace OrientacaoObjeto.Exercicios
{
    internal class Aluno
    {
        // Escreva uma classe Aluno contendo todos os atributos de um aluno. Faça métodos para apresentar os dados.
        // Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

        public string nome;
        public string cpf;
        public DateOnly nascimento;
        public string ra;

        public Aluno(string nome, string cpf, DateOnly nascimento, string ra)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
            this.ra = ra;
        }

        public void GetNome()
        {
            Console.WriteLine("Nome: " + nome);
        }
        public void GetCpf()
        {
            Console.WriteLine("CPF: " + cpf);
        }
        public void GetNascimento()
        {
            Console.WriteLine("Nascimento: " + nascimento);
        }
        public void GetRa()
        {
            Console.WriteLine("RA: " + ra);
        }
    }
}
