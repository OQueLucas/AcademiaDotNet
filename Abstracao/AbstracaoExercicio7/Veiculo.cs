namespace AbstracaoExercicio7
{
    internal class Veiculo
    {
        public Veiculo(string marca, int ano)
        {
            Marca = marca;
            Ano = ano;
        }

        public string Marca { get; set; }
        public int Ano { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca}, ano: {Ano}");
        }
    }
}
