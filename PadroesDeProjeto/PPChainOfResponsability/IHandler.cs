namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal interface IHandler
    {
        void DefinirProximoHandler(IHandler proxHandler);
        void AprovarDespesa(Despesa despesa);
    }
}
