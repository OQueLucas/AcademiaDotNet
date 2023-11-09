namespace AbstracaoExercicio2
{
    internal class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {QuantidadeDePortas} portas");
        }
    }
}
