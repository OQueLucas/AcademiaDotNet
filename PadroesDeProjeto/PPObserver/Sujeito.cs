namespace PadroesDeProjeto.PPObserver
{
    internal class Sujeito
    {
        private List<IObservador> observadores = new();

        public void RegistrarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void RemoverObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var o in observadores)
            {
                o.Atualizar(mensagem);
            }
        }
    }
}
