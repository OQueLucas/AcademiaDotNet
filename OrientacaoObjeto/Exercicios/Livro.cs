using System;

namespace OrientacaoObjeto.Exercicios
{
    internal class Livro
    {
        // Crie uma classe Livro que represente os dados básicos de um livro, além destes, criar um atributo do tipo boolean chamado emprestado.
        // Crie métodos emprestar e devolver que altera o atributo emprestado
        // Crie um método construtor que receba todos os valores por parâmetros,
        // exceto o atributo emprestado que obrigatoriamente deve ser inicializado como false
        // Faça a leitura pelo teclado dos atributos para instanciar dois livros


        public string titulo;
        public string autor;
        public int anoPublicacao;
        public bool emprestado;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public void Emprestar()
        {
            if (emprestado)
            {
                Console.WriteLine("Esse livro já foi emprestado!");
            } else
            {
                emprestado = true;
            }
        }

        public void Devolver()
        {
            if (emprestado)
            {
                emprestado = false;
            }
            else
            {
                Console.WriteLine("Livro já está no estoque");
            }
        }



        //Livro livro1 = new();
        //Console.WriteLine("Insira o título do livro: ");
        //livro1.titulo = Console.ReadLine();
        //Console.WriteLine("Insira o nome do autor: ");
        //livro1.autor = Console.ReadLine();
        //Console.WriteLine("Insira o ano de publicação: ");
        //livro1.anoPublicacao = int.Parse(Console.ReadLine());

        //Livro livro2 = new();
        //Console.WriteLine("Insira o título do livro: ");
        //livro2.titulo = Console.ReadLine();
        //Console.WriteLine("Insira o nome do autor: ");
        //livro2.autor = Console.ReadLine();
        //Console.WriteLine("Insira o ano de publicação: ");
        //livro2.anoPublicacao = int.Parse(Console.ReadLine());


        //Console.WriteLine("O " + livro0.titulo + " escrito por " + livro0.autor + " foi publicado em " + livro0.anoPublicacao);
        //Console.WriteLine("O " + livro1.titulo + " escrito por " + livro1.autor + " foi publicado em " + livro1.anoPublicacao);
        //Console.WriteLine("O " + livro2.titulo + " escrito por " + livro2.autor + " foi publicado em " + livro2.anoPublicacao);
    }
}
