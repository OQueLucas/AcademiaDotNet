namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> listaLivros = new();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o título do livro: ");
                string titulo = Console.ReadLine();
                Console.WriteLine("Insira o nome do autor: ");
                string autorNome = Console.ReadLine();
                Console.WriteLine("Insira a nacionalidade do autor: ");
                string nacionalidadeAutor = Console.ReadLine();

                Autor autor = new(autorNome, nacionalidadeAutor);

                Console.WriteLine("Insira o ano de publicação: ");
                int anoPublicacao = int.Parse(Console.ReadLine());

                Livro livro0 = new(titulo, autor, anoPublicacao);


                listaLivros.Add(livro0);
            }

            foreach (Livro livro in listaLivros)
            {
                livro.ExibirInformacoes();
            }

        }
    }
}