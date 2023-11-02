namespace OrientacaoObjeto.Desafios02
{
    internal class Produto
    {
        // 2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de
        // compras (data, produto, valor). Implemente um construtor e métodos para adicionar e listar compras.

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
