namespace AbstracaoExercicio5
{
    internal abstract class Produto
    {
        protected Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract double CalcularDesconto();
    }
}
