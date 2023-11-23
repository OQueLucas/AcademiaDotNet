namespace PadroesDeProjeto.PPProxy
{
    internal class ServicoReal : IServico
    {
        public void Solicitar()
        {
            Console.WriteLine("Serviço real: Serviço solicitado pelo cliente!");
        }
    }
}
