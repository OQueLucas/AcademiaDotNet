namespace PadroesDeProjeto.PPTemplateMothod
{
    internal class ProcessoA : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoA");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o ProcessoA");
        }
    }
}
