namespace AbstracaoExercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar um método abstrato chamado Dirigir. 
             * Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. 
            A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
            Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e 
            um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"*/

            Carro carro = new()
            {
                Marca = "Fiat",
                Modelo = "Mobi",
                QuantidadeDePortas = 4
            };

            Moto moto = new()
            {
                Marca = "Honda",
                Modelo = "Biz 100",
                Cilindradass = 97
            };

            carro.Dirigir();

            moto.Dirigir();
        }
    }
}