namespace OrientacaoObjeto.Exercicio09
{
    internal class Livro
    {
        // 9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.

        private string _titulo;
        private string _autor;

        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titulo = value;
                }
            }
        }
        public string Autor
        {
            get
            {
                return _autor;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _autor = value;
                }
            }
        }
        public Livro() { }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
