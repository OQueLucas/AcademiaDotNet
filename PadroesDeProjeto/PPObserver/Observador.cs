namespace PadroesDeProjeto.PPObserver
{
    internal class Observador : IObservador
    {
        private string _nome;

        public Observador(string nome)
        {
            _nome = nome;
        }

        public void Atualizar(string mensagem)
        {
            Console.WriteLine(_nome + " recebeu a mensagem " + mensagem);
        }
    }
}
