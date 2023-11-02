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
            emprestado = false;
        }

        public void Emprestar()
        {
            if (emprestado)
            {
                Console.WriteLine("Esse livro já foi emprestado!");
            }
            else
            {
                Console.WriteLine("Livro emprestado com sucesso!");
                emprestado = true;
            }
        }

        public void Devolver()
        {
            if (emprestado)
            {
                Console.WriteLine("Livro devolvido com sucesso!");
                emprestado = false;
            }
            else
            {
                Console.WriteLine("Livro já está no estoque");
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Titulo: " + this.titulo);
            Console.WriteLine("Autor: " + this.autor);
            Console.WriteLine("Ano de publicação: " + this.anoPublicacao);
            Console.WriteLine(emprestado ? "Livro indisponível, já foi emprestado!" : "Livro disponível!");
        }
    }
}
