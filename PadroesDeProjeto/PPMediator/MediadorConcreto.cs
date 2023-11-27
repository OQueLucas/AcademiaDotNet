namespace PadroesDeProjeto.PPMediator
{
    internal class MediadorConcreto : Mediador
    {
        public Colega1 colega1;
        public Colega2 colega2;

        public override void Enviar(string messagem, Colega colega)
        {
            if (colega == colega1)
            {
                colega1.Notificar(messagem);
            }
            else if (colega == colega2)
            {
                colega2.Notificar(messagem);
            }
        }
    }
}
