namespace PadroesDeProjeto.Fachada
{
    internal class SistemaBancoDeDados
    {
        public void ConfigurarBancoDeDados()
        {
            Console.WriteLine("Banco de dados configurado!");
        }

        public void IniciarBancoDeDados()
        {
            ConfigurarBancoDeDados();
            Console.WriteLine("Iniciando banco de dados!");
        }
    }
}
