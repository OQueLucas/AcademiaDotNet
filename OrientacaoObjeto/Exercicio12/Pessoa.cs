using System.Globalization;

namespace OrientacaoObjeto.Exercicio12
{
    internal class Pessoa
    {
        // 12 - Crie uma classe Pessoa que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
        // void armazenaPessoa(String nome, int idade, float altura);
        // void removePessoa(String nome);
        // Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
        // void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
        // Faça um menu para navegar entre as opções infinitamente.

        private string _nome;
        private int _idade;
        private float _altura;

        public Pessoa() { }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }


        public string Nome { get { return _nome; } set { _nome = value; } }
        public int Idade { get { return _idade; } set { _idade = value; } }
        public float Altura { get { return _altura; } set { _altura = value; } }

        public override string ToString()
        {
            return Nome
                + ", " + Idade + " anos"
                + ", " + Altura.ToString("F1", CultureInfo.InvariantCulture) + "m";
        }
    }
}
