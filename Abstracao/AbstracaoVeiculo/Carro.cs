
namespace AbstracaoVeiculo
{
    internal class Carro : IVeiculo
    {
        private int _velocidade;
        public void Acelerar()
        {
            _velocidade++;
            Console.WriteLine(_velocidade);
        }

        public void Frear()
        {
            _velocidade--;
            Console.WriteLine(_velocidade);
        }
    }
}
