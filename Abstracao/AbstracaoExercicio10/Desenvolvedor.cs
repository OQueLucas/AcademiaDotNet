namespace AbstracaoExercicio10
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, double salario, string linguagemPrincipal) : base(nome, salario)
        {
            LinguagemPrincipal = linguagemPrincipal;
        }

        public string LinguagemPrincipal { get; set; }

        public override void Bonus()
        {
            throw new NotImplementedException();
        }

        public override void Funcao()
        {
            Console.WriteLine(Nome + ", Salario: " + Salario + ", Linguagem principal: " + LinguagemPrincipal);
        }
    }
}
