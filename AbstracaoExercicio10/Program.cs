namespace AbstracaoExercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10 - 
             * a) Crie uma classe base "Funcionario" com propriedades como "Nome" e "Salario."
             * b) Crie classes derivadas, como "Gerente" e "Desenvolvedor," que herdem de "Funcionario" e forneçam implementações específicas para calcular bônus ou mostrar funções.
             */

            List<Funcionario> funcionarios = new()
            {
                new Gerente("Ricardo", 5823.12, "API UFN"),
                new Desenvolvedor("Lucas", 2340.23, "C#")
            };

            foreach (var funcionario in funcionarios)
                funcionario.Funcao();
        }
    }
}