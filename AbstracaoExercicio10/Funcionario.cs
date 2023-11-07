namespace AbstracaoExercicio10
{
    internal abstract class Funcionario
    {
        protected Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public double Salario { get; set; }

        public abstract void Bonus();
        public abstract void Funcao();
    }
}
