namespace AbstracaoExercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.  
            A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina.  
            Criar um método abstrato Apresentar na classe Pessoa. 
            Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe 
            Professor que imprime o nome, a idade e a disciplina do professor. */

            Professor professor = new()
            {
                Nome = "Ricardo",
                Idade = 34,
                Disciplina = "Orientação a Objetos"
            };

            Aluno aluno = new()
            {
                Nome = "Lucas Queiroz",
                Idade = 24,
                Matricula = "DE21423"
            };

            professor.Apresentar();

            aluno.Apresentar();
        }
    }
}