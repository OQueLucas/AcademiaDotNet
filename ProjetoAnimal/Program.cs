namespace AbstracaoAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estamos no teste de animais");

            Gato gato = new("Jake")
            {
                Idade = 3,
                Especie = "Siames"
            };

            gato.EmitirSom();
            gato.Ronronar();
            Console.WriteLine(gato);
        }
    }
}