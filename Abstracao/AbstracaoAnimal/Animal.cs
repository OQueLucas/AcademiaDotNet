namespace AbstracaoAnimal
{
    internal abstract class Animal
    {
        private string _nome;
        private string _especie;
        private int _idade;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Especie { get { return _especie; } set { _especie = value; } }
        public int Idade { get { return _idade; } set { _idade = value; } }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public abstract void EmitirSom();
        
        public virtual void Movimentar()
        {
            Console.WriteLine("Animal está se movimentando! ");
        }

        public override string ToString()
        {
            return Nome + " tem " + Idade + " e é um " + Especie;
        }
    }
}
