namespace PadroesDeProjeto.PPStrategy
{
    internal class ContextoOrdenacao
    {
        private IAlgoritmoOrdenacao _algoritmo;

        public ContextoOrdenacao(IAlgoritmoOrdenacao algoritmo)
        {
            Algoritmo = algoritmo;
        }

        internal IAlgoritmoOrdenacao Algoritmo { get => _algoritmo; set => _algoritmo = value; }

        public void ExecutarOrdenacao(List<int> lista)
        {
            _algoritmo.Ordernar(lista);
        }
    }
}
