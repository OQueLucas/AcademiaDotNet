namespace Biblioteca
{
    internal class Autor
    {
        public string nome;
        public string nacionalidade;

        public Autor(string nome, string nacionalidade)
        {
            this.nome = nome;
            this.nacionalidade = nacionalidade;
        }

        public override string ToString()
        {
            return "Nome do autor: " + this.nome +
                "\nNacionalidade do autor: " + this.nacionalidade;
        }
    }
}
