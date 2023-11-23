namespace PadroesDeProjeto.PPProxy
{
    internal class Proxy : IServico
    {
        private ServicoReal _servicoReal;
        public void Solicitar()
        {
            if (_servicoReal == null)
            {
                _servicoReal = new ServicoReal();
                Console.WriteLine("Instanciando um objeto da classe serviço real!");
            }
            else
                Console.WriteLine("Já foi instanciado anteriormente");

            Console.WriteLine("Estou aqui no proxy chamando o serviço real!");

            _servicoReal.Solicitar();
        }
    }
}
