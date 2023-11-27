namespace PadroesDeProjeto.PPTemplateMothod
{
    sealed internal class ProcessoB : Processo
        // aqui, nesta classe, não poderemos mais herdá-la pois definimos como selada.
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoB");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o ProcessoB");
        }
    }
}
