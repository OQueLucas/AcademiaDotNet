namespace OrientacaoObjeto.Exercicio08
{
    internal class Fabricante
    {
        // 8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.
        // Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco.
        // Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 

        public Fabricante() { }

        private string _name;
        private string _endereco;
        private string _cidade;

        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }
        public string Nome
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
    }
}
