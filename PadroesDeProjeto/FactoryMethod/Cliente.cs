namespace PadroesDeProjeto.FactoryMethod
{
    internal class Cliente
    {
        private IAnimalFactory animalFactory;

        public Cliente(IAnimalFactory factory)
        {
            this.animalFactory = factory;
        }

        public void InteragirComAnimal()
        {
            IAnimal animal = animalFactory.CriarAnimal();
            Console.WriteLine("Animal faz o som:");
            animal.FazerSom();
        }
    }
}
