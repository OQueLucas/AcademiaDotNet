namespace OrientacaoObjeto.Exercicio06
{
    internal class Produtos
    {
        // 6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

        List<Produto> produtos = new();

        public void AdicionarProduto(int codigo, string nome, double preco, int quantidadeEstoque)
        {
            produtos.Add(new(codigo, nome, preco, quantidadeEstoque));
        }

        public void ListarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        public void ConsultarProduto(string nome)
        {
            Produto produto = produtos.Find(x => x.nome.Equals(nome));

            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado");
            }
            else
            {
                Console.WriteLine(produto);
            }
        }
    }
}
