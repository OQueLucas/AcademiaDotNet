namespace OrientacaoObjeto.Desafios.Imobiliaria
{
    internal class CorretoraDeImoveis
    {
        // 3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
        // Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio
        // Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.
        // Insira os imoveis numa lista para facilitar o trabalho.

        public List<Imovel> imoveis = new();

        public void AdicionarImoveis(string endereco, double preco, string tipo)
        {
            Imovel imovel = new(endereco, preco, tipo);
            imoveis.Add(imovel);
        }

        public void CadastrarImoveis()
        {
            Console.Write("Digite o endereço do Imóvel: ");
            string endereco = Console.ReadLine();
            Console.Write("Insira o preço: ");
            double preco = double.Parse( Console.ReadLine());
            Console.Write("Insira o tipo: ");
            string tipo = Console.ReadLine();

            AdicionarImoveis(endereco, preco, tipo);
        }

        public double PrecoMedio()
        {
            double total = 0;

            foreach (var imovel in imoveis)
            {
                total += imovel.preco;
            }
            return total / imoveis.Count;
        }

        public void AlterarPreco()
        {
            Console.Write("Insira o imóvel que deseja alterar o valor: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Insira o valor que deseja atualizar: ");
            double preco = double.Parse(Console.ReadLine());

            Imovel? imovel = imoveis.Find(imovel => imovel.endereco.Contains(endereco));

            if (imovel == null)
            {
                Console.WriteLine("Imóvel não encontrado");
            }
            else
            {
                imovel.preco = preco;
                Console.WriteLine(imovel);
            }
        }

        public void ListarImoveis()
        {
            foreach (var imovel in imoveis)
            {
                Console.WriteLine(imovel);
            }
        }
        // Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.

        public void Menu()
        {
            Console.WriteLine("Bem vindo a corretora!");
            byte opcao;

            do
            {
                Console.WriteLine("Selecione a opção que deseja realizar: (1 - Inserir imóvel / 2 - Alterar preço / 3 - Listar imóveis / 4 - Preço médio / 5 - Sair)");
                Console.Write("Opção: ");
                opcao = byte.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CadastrarImoveis();
                        break;
                    case 2:
                        AlterarPreco();
                        break;
                    case 3:
                        ListarImoveis();
                        break;
                    case 4:
                        Console.WriteLine(PrecoMedio()) ;
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
            while (opcao != 5);
        }
    }
}
