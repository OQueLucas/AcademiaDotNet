namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Diretor : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 1000)
            {
                Console.WriteLine("Despesa aprovada pelo Diretor!");
            }
            else if (ProximoHandler != null)
            {
                ProximoHandler.AprovarDespesa(despesa);
            }
            else
            {
                Console.WriteLine("O Diretor não pode aprovar esta conta!");
            }
        }
    }
}
