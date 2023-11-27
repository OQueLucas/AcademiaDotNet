using PadroesDeProjeto;
using PadroesDeProjeto.Fachada;
using PadroesDeProjeto.FactoryMethod;
using PadroesDeProjeto.PPChainOfResponsability;
using PadroesDeProjeto.PPMediator;
using PadroesDeProjeto.PPObserver;
using PadroesDeProjeto.PPProxy;
using PadroesDeProjeto.PPStrategy;
using PadroesDeProjeto.PPTemplateMothod;

namespace PadroesDeProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new();

            // aqui vamos ter todas as variaçõies, ou seja, as estratégias do algoritmo
            IAlgoritmoOrdenacao bubble = new BubbleSort();
            IAlgoritmoOrdenacao quick = new QuickSort();
            IAlgoritmoOrdenacao insert = new InsertSort();

            // agora com o contexto, vamos abstratur tudo que foi definido nas estratégias
            ContextoOrdenacao contOrd = new(insert);

            // agr vamos executar  algoritmo seleciona na lista
            contOrd.ExecutarOrdenacao(lista);

            // vamos mudar o algoritmo;

            contOrd.Algoritmo = quick;
            contOrd.ExecutarOrdenacao(lista);

            // vamos mudar novamente o algoritmo
            contOrd.Algoritmo = bubble;
            contOrd.ExecutarOrdenacao(lista);
        }
    }
}

//// Instanciamos os tres papéis, ou seja, a cadeira de manipuladores de responsabilidade
//IHandler gerente = new Gerente();
//IHandler diretor = new Diretor();
//IHandler presidente = new Presidente();
//IHandler proprietario = new Proprietario();

//gerente.DefinirProximoHandler(diretor);
//        diretor.DefinirProximoHandler(presidente);
//        presidente.DefinirProximoHandler(proprietario);

//        Despesa d1 = new("Boleto da água", 450);
//Despesa d2 = new("Conta do bar da esquina", 950);
//Despesa d3 = new("Obra do banheiro", 4500);
//Despesa d4 = new("Conta da lancheria da Academia", 9000);

//gerente.AprovarDespesa(d1);
//        Console.WriteLine();
//        gerente.AprovarDespesa(d2);
//        Console.WriteLine();
//        gerente.AprovarDespesa(d3);
//        Console.WriteLine();
//        gerente.AprovarDespesa(d4);

//        /*
//        diretor.AprovarDespesa(d1);
//        diretor.AprovarDespesa(d2);
//        diretor.AprovarDespesa(d3);

//        presidente.AprovarDespesa(d1);
//        presidente.AprovarDespesa(d2);
//        presidente.AprovarDespesa(d3);
//        */

// -------------------------------------------------------------------------

//Console.WriteLine("Testando o padrão Observer");
//Sujeito s = new(); // Seria a loja que tem o produto

//// agora vamos adicionar os interessados no assunto ou produto
//Observador o1 = new("Ricardo");
//Observador o2 = new("Fabricio");
//Observador o3 = new("Alexandre");
//Observador o4 = new("Guilherme");

//s.RegistrarObservador(o1);
//s.RegistrarObservador(o2);
//s.RegistrarObservador(o3);
//s.RegistrarObservador(o4);
//s.RegistrarObservador(new Observador("Ana Paula"));

//s.NotificarObservadores("A aula de hoje não está legal!");

//s.RemoverObservador(o4);

//s.NotificarObservadores("O Guilherme foi embora pois está chato pra caramba");

// ---------------------------------------------------------------------------

//Console.WriteLine("Testando o padrão Template Method");

//Console.WriteLine("Iniciamos usando o Processo A");
//Processo processo;
//processo = new ProcessoA();
//processo.Executar();

//Console.WriteLine();

//Console.WriteLine("Vamos mudar, agora ele vai virar o Processo B");
//processo = new ProcessoB();
//processo.Executar();

//Console.WriteLine();

//Console.WriteLine("Vamos mudar, agora ele vai virar o Processo C");
//processo = new ProcessoC();
//processo.Executar();

// ------------------------------------------------------------------------------------

//MediadorConcreto mediator = new();

//Colega1 c1 = new(mediator);
//Colega2 c2 = new(mediator);

//mediator.colega1 = c1;
//mediator.colega2 = c2;

//c1.Enviar("Mensagem enviada pra 1");
//c2.Enviar("Mensagem enviada pra 2");

// -------------------------------------------------------------------------------------


//IServico proxy = new Proxy();
//proxy.Solicitar();

//Console.WriteLine();

//IServico proxy2 = new Proxy();
//proxy2.Solicitar();

// --------------------------------------------------------------------------------------

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