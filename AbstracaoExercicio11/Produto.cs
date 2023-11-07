namespace AbstracaoExercicio11
{
    internal class Produto
    {
        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public override string ToString()
        {
            return Nome
                + ", Preço: " + Preco
                + ", Estoque: " + Estoque;
        }
    }
}
