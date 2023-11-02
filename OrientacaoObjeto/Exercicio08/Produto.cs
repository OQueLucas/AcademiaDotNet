namespace OrientacaoObjeto.Exercicio08
{
    internal class Produto
    {
        // 8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.
        // Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco.
        // Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 

        public Produto() { }

        public Produto(string nome, Fabricante fabricante, double preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }

        private string _name;
        private Fabricante _fabricante;
        private double _preco;

        public string Nome
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public Fabricante Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            }
        }
    }
}
