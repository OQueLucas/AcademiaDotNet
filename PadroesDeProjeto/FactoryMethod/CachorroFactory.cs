namespace PadroesDeProjeto.FactoryMethod
{
    internal class CachorroFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            //Cachorro c = new Cachorro();
            //return c;

            return new Cachorro();
        }
    }
}
