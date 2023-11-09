namespace AbstracaoExercicio1
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public abstract void Apresentar();
    }
}
