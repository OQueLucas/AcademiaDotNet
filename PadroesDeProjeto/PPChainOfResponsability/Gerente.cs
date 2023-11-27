namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Gerente : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 500)
            {
                Console.WriteLine("Despesa aprovada pelo Gerente!");
            }
            else if (ProximoHandler != null)
            {
                ProximoHandler.AprovarDespesa(despesa);
            }
            else
            {
                Console.WriteLine("O Gerente não pode aprovar esta conta!");
            }
        }
    }
}
