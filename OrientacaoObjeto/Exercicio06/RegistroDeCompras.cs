namespace OrientacaoObjeto.Exercicio06
{
    internal class RegistroDeCompras
    {
        // 6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

        public DateTime dataDeCompra;
        public string produto;
        public double valor;
        public int quantidade;

        public RegistroDeCompras(DateTime dataDeCompra, Produto produto, int quantidade)
        {
            this.dataDeCompra = dataDeCompra;
            this.produto = produto.nome;
            valor = produto.preco;
            this.quantidade = quantidade;
        }
    }
}
