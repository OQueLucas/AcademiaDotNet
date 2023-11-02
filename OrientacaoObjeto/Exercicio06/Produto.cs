namespace OrientacaoObjeto.Exercicio06
{
    internal class Produto
    {
        // 6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

        public int codigo;
        public string nome;
        public double preco;
        public int quantidadeEstoque;

        public Produto(int codigo, string nome, double preco, int quantidadeEstoque)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public void AdicionarEstoque(int quantidade)
        {
            quantidadeEstoque += quantidade;
        }
        public void RemoverEstoque(int quantidade)
        {
            quantidadeEstoque -= quantidade;
        }

        public override string ToString()
        {
            return "Cod." + codigo
                + "\t produto: " + nome
                + "\t preço: " + preco
                + "\t Quantidade em Estoque: " + quantidadeEstoque;
        }
    }
}
