namespace AbstracaoExercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto".
             * Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto"
             * de acordo com as regras específicas de desconto para cada tipo de produto.
             * Livro – 5% de desconto
             * Eletrônico  - 12.5% de desconto*/

            Livro livro0 = new("Narnia", 80);

            Console.WriteLine(livro0.CalcularDesconto());

            Eletronico eletronico0 = new("Redmi 8", 2000);
            Console.WriteLine(eletronico0.CalcularDesconto());
        }
    }
}