using PadroesDeProjeto;
using PadroesDeProjeto.Fachada;
using PadroesDeProjeto.FactoryMethod;
using PadroesDeProjeto.PPProxy;

namespace PadroesDeProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServico proxy = new Proxy();
            proxy.Solicitar();

            Console.WriteLine();

            IServico proxy2 = new Proxy();
            proxy2.Solicitar();
        }
    }
}

//Console.WriteLine("Testando a classe Facade");
//Facade fachada = new("root", "1234");
//fachada.InicializarSistema();

///*A utilização do facade evita com que seja necessário sempre alterar 
//no cliente novos componentes.
//tudo ficará centraliado na classe Facade
//SistemaBancoDeDados sbd = new SistemaBancoDeDados();
//SistemaServidorWeb ssw = new SistemaServidorWeb();
//SistemaAutenticacao sa = new SistemaAutenticacao("root", "1234");
//sbd.IniciarBancoDeDados();
//ssw.IniciarServidor();
//sa.IniciarSistema();*/

// ---------------------------------------------------------------------------------------

//Console.WriteLine("Testando o padrão de projeto Factory Method");

//// eu quero a adiar a decisão de qual classe instanciar
////Cachorro c = new Cachorro();
////c.FazerSom();
//// agora, podemos adiar  a decisao de qual objetovamos instanciar uma

//IAnimalFactory cFactory = new CachorroFactory();
//Cliente cli1 = new(cFactory);
//cli1.InteragirComAnimal();


//IAnimalFactory gFactory = new GatoFactory();
//Cliente cli2 = new(gFactory);
//cli2.InteragirComAnimal();

//List<Cliente> listaClientes = new()
//            {
//                cli1,
//                cli2,
//                new(cFactory), // to adicionando outro cachorro
//                new(gFactory)
//            };

//foreach (var animal in listaClientes)
//{
//    animal.InteragirComAnimal();
//}

// ---------------------------------------------------------------------------------------

//Console.WriteLine("Testando a classe configuração usando o padrão singleton");

//ConfiguracaoSingleton config = ConfiguracaoSingleton.getInstance();
//config.ExibirDados();


//ConfiguracaoSingleton config2 = ConfiguracaoSingleton.getInstance();
//config.ExibirDados();

//if (config == config2)
//    Console.WriteLine("Mesma instancia");

//// Linha de baixo, estou chamabndo o construtor no cliente
//// Isso não podemos, pois criamos uma outra instancia. O construtor deve ser privado ou protegido!
////ConfiguracaoSingleton config3 = new();
//ConfiguracaoSingleton config3 = ConfiguracaoSingleton.getInstance();
//config.ExibirDados();

//if (config == config3)
//    Console.WriteLine("Mesma instancia");
//else
//    Console.WriteLine("Diferente instancia");