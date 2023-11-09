namespace AbstracaoExercicio5
{
    internal class Livro : Produto
    {
        public Livro(string nome, double preco) : base(nome, preco)
        {
        }

        public override double CalcularDesconto()
        {
            return Preco - (Preco * 0.05);
        }
    }
}
