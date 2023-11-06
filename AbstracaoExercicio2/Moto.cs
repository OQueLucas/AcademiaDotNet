namespace AbstracaoExercicio2
{
    internal class Moto : Veiculo
    {
        public int Cilindradass { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {Cilindradass} cilindradas");
        }
    }
}
