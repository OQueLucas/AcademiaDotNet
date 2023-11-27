namespace PadroesDeProjeto.PPTemplateMothod
{
    internal class ProcessoC : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoC");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o ProcessoC");
        }

        sealed public override void Executar() // Sealed eu impossibilito que esta implementação seja sobrescrita.
        {
            Console.WriteLine("Estou no metodo reimplementado do ProcessoC");
            Iniciar();
            //RegistrarProcesso();
            Finalizar();
        }
    }
}
