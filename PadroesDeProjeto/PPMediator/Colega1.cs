namespace PadroesDeProjeto.PPMediator
{
    internal class Colega1 : Colega
    {
        public Colega1(Mediador meadiator) : base(meadiator)
        {
        }

        public override void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public override void Notificar(string mensagem) {
            Console.WriteLine("Colega 1 recebeu a mensagem: " + mensagem);
        }
    }
}
