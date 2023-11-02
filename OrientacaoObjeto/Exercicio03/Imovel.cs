namespace OrientacaoObjeto.Exercicio03
{
    internal class Imovel
    {
        // 3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
        // Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio
        // Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.
        // Insira os imoveis numa lista para facilitar o trabalho.

        public string endereco;
        public double preco;
        public string tipo;

        public Imovel(string endereco, double preco, string tipo)
        {
            this.endereco = endereco;
            this.preco = preco;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return "Endereço: " + endereco
                + "\tPreço: " + preco
                + "\tTipo: " + tipo;
        }
    }
}
