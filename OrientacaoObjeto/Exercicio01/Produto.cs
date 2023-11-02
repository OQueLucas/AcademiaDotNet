namespace OrientacaoObjeto.Exercicio01
{
    internal class Produto
    {
        // 1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque.
        // Implemente um construtor e métodos para adicionar e remover itens do estoque.

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
