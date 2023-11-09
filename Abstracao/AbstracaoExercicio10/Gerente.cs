namespace AbstracaoExercicio10
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salario, string time) : base(nome, salario)
        {
            Time = time;
        }

        public string Time { get; set; }

        public override void Bonus()
        {
            throw new NotImplementedException();
        }

        public override void Funcao()
        {
            Console.WriteLine(Nome + ", Salario: " + Salario + ", Gerencia o time: " + Time);
        }
    }
}
