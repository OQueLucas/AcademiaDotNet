namespace PadroesDeProjeto.PPChainOfResponsability
{
    internal class Proprietario : Aprovador
    {
        public override void AprovarDespesa(Despesa despesa)
        {
            if (despesa.Valor <= 50000)
            {
                Console.WriteLine("Despesa aprovada pelo Proprietario!");
            }
            else
            {
                Console.WriteLine("O Proprietario não pode aprovar esta conta!");
            }
        }
    }
}
