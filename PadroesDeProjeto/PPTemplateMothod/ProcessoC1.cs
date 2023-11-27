namespace PadroesDeProjeto.PPTemplateMothod
{
    internal class ProcessoC1 : ProcessoC
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoC");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o ProcessoC");
        }

        // public override void Executar() {  }
    }
}
