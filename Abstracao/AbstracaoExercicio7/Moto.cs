namespace AbstracaoExercicio7
{
    internal class Moto : Veiculo
    {
        public Moto(string marca, int ano, int cilindradas) : base(marca, ano)
        {
            Cilindradas = cilindradas;
        }

        public int Cilindradas { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca}, ano: {Ano}, cilindradas: {Cilindradas}");
        }
    }
}
