namespace AbstracaoAnimal
{
    internal class Gato : Animal
    {
        public int Vidas { get; }

        public Gato(string nome) : base(nome) {}

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Correr no telhado a noite!");
        }

        public void Ronronar()
        {
            Console.WriteLine("Gato ronronando... ");
            Console.WriteLine("Prrrrrr");
        }
    }
}
