namespace PadroesDeProjeto.PPMediator
{
    internal class Colega2 : Colega
    {
        public Colega2(Mediador meadiator) : base(meadiator)
        {
        }

        public override void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this);
        }

        public override void Notificar(string mensagem)
        {
            Console.WriteLine("Colega 2 recebeu a mensagem: " + mensagem);
        }
    }
}
