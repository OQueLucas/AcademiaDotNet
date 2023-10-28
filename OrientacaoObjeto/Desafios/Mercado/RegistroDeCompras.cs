namespace OrientacaoObjeto.Desafios.Mercado
{
    internal class RegistroDeCompras
    {

        // 2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de
        // compras (data, produto, valor). Implemente um construtor e métodos para adicionar e listar compras.

        public DateTime dataDeCompra;
        public string produto;
        public double valor;
        public int quantidade;

        public RegistroDeCompras(DateTime dataDeCompra, Produto produto, int quantidade)
        {
            this.dataDeCompra = dataDeCompra;
            this.produto = produto.nome;
            this.valor = produto.preco;
            this.quantidade = quantidade;
        }
    }
}
