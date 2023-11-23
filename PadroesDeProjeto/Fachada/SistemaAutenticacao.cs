namespace PadroesDeProjeto.Fachada
{
    internal class SistemaAutenticacao
    {
        private string _user;
        private string _password;

        public SistemaAutenticacao(string user, string password)
        {
            _user = user;
            _password = password;
        }

        public bool VerificaDados()
        {
            return _user.Equals("root") && _password.Equals("1234");
        }

        public void IniciarSistema()
        {
            if(VerificaDados())
                Console.WriteLine("Sistema iniciado!");
            else
                Console.WriteLine("Verifique usuário e senha!");
        }
    }
}
