namespace AbstracaoExercicio1
{
    internal class Professor : Pessoa
    {
        public string Disciplina {  get; set; }

        public override void Apresentar()
        {
            Console.WriteLine("nome: " + Nome + ", idade: " + Idade + ", disciplina: " + Disciplina);
        }
    }
}
