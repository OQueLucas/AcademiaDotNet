namespace AbstracaoExercicio9
{
    internal class Estudante : Pessoa
    {
        public Estudante(string nome, int idade, string matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public string Matricula { get; set; }
        public string Curso { get; set; }
    }
}
