namespace AbstracaoExercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11 - 
             * a) Crie uma classe "Produto" com propriedades como "Nome," "Preço" e "Estoque."
             * b) Implemente construtores sobrecarregados que permitam criar instâncias de produtos de diferentes maneiras, 
             * como especificando apenas o nome ou especificando todas as propriedades.
             */

            List<Produto> lista = new() {
                new Produto("Alface"),
                new Produto("Melancia"),
                new Produto("Bolacha", 1.20, 38),
                new Produto("Agua", 4.50, 200)
            };

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}