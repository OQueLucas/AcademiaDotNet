namespace PadroesDeProjeto.FactoryMethod
{
    internal class Cachorro : IAnimal
    {
        public string Raca { get; set; }
        public void FazerSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}
