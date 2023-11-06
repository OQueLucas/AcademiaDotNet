namespace AbstracaoExercicio5
{
    internal class Eletronico : Produto
    {
        public Eletronico(string nome, double preco) : base(nome, preco)
        {
        }

        public override double CalcularDesconto()
        {
            return Preco - (Preco * 0.125);
        }
    }
}
