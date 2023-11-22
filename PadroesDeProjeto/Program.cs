namespace PadroesDeProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a classe configuração usando o padrão singleton");

            ConfiguracaoSingleton config = ConfiguracaoSingleton.getInstance();
            config.ExibirDados();


            ConfiguracaoSingleton config2 = ConfiguracaoSingleton.getInstance();
            config.ExibirDados();

            if (config == config2)
                Console.WriteLine("Mesma instancia");

            // Linha de baixo, estou chamabndo o construtor no cliente
            // Isso não podemos, pois criamos uma outra instancia. O construtor deve ser privado ou protegido!
            //ConfiguracaoSingleton config3 = new();
            ConfiguracaoSingleton config3 = ConfiguracaoSingleton.getInstance();
            config.ExibirDados();

            if (config == config3)
                Console.WriteLine("Mesma instancia");
            else
                Console.WriteLine("Diferente instancia");

        }
    }
}
