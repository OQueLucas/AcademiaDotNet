namespace AbstracaoAnimal
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }
    }
}
