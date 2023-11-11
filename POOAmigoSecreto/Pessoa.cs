namespace POOAmigoSecreto
{
    internal class Pessoa
    {
        private string _nome;
        private string _email;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public Pessoa() { }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ";" + Email;
        }

        public override bool Equals(object? obj)
        {
            Pessoa PessoaObj = obj as Pessoa;

            if (obj == null) return false;

            return Email.ToUpper().Equals(PessoaObj.Email.ToUpper());
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
