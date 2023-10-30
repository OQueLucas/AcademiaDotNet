namespace POOAlexandre
{
    public class Treinador : Pessoa
    {
        public string RegistroConselho { set; get; }
        public string Clube { set; get; }

        public Treinador(string nome, string email, DateOnly data, string registroConselho, string clube) : base(nome, email, data)
        {
            RegistroConselho = registroConselho;
            Clube = clube;
        }
    }
}
