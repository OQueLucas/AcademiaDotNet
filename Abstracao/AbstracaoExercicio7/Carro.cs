namespace AbstracaoExercicio7
{
    internal class Carro : Veiculo
    {
        public Carro(string marca, int ano, int numeroDePortas) : base(marca, ano)
        {
            NumeroDePortas = numeroDePortas;
        }

        public int NumeroDePortas { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca}, ano: {Ano}, numero de portas {NumeroDePortas}");
        }
    }
}
