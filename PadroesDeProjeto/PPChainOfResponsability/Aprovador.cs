namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal abstract class Aprovador : IHandler
    {
        protected IHandler ProximoHandler;

        // ainda estou adiando a implementação desse metodo
        public abstract void AprovarDespesa(Despesa despesa);

        public void DefinirProximoHandler(IHandler proxHandler)
        {
            ProximoHandler = proxHandler;
        }
    }
}
