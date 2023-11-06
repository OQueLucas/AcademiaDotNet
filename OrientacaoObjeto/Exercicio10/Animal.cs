namespace OrientacaoObjeto.Exercicio10
{
    internal class Animal
    {
        // 10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado EmitirSom, que imprime na tela o som do animal.

        private string _nome;
        private string _especie;
        private int _idade;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Especie { get { return _especie; } set { _especie = value; } }
        public int Idade { get { return _idade; } set { _idade = value; } }

        public Animal(string nome, string especia, int idade)
        {
            Nome = nome;
            Especie = especia;
            Idade = idade;
        }

        Dictionary<string, string> sons = new() {
            { "GATO", "Miau" },
            { "CACHORRO", "Au au" },
            { "VACA", "Muuu" },
            { "ABELHA", "Bzzzzzz" },
            { "CAVALO", " iiirrrrí, rilinchin" }
        };

        public void EmitirSom()
        {
            if (sons.TryGetValue(_especie.ToUpper(), out string som))
            {
                Console.WriteLine(som);
            }
            else
            {
                Console.WriteLine("Som não existe em nossa biblioteca.");
            }
        }
    }
}
