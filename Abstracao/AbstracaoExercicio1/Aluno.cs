namespace AbstracaoExercicio1
{
    internal class Aluno : Pessoa
    {
        public string Matricula {  get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("nome: " + Nome + ", idade: " + Idade + ", matricula: " + Matricula);
        }
    }
}
