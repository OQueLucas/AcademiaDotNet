namespace PadroesDeProjeto.FactoryMethod
{
    internal class GatoFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            return new Gato();
        }
    }
}
