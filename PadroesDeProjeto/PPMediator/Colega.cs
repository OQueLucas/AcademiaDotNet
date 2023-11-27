namespace PadroesDeProjeto.PPMediator
{
    public abstract class Colega
    {
        protected Mediador _mediator { get; set; }

        public Colega(Mediador meadiator)
        {
            _mediator = meadiator;
        }

        public abstract void Enviar(string mensagem);
        public abstract void Notificar(string mensagem);
    }
}