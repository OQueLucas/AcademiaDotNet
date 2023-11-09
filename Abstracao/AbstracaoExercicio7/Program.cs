namespace AbstracaoExercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."
             * b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas, 
             * como "Número de Portas" para carros e "Cilindrada" para motos.
             * c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto." Use um loop para percorrer a 
             * lista e chamar um método "Apresentar" que exibe informações sobre cada veículo, demonstrando o polimorfismo.
             * d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
             * e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.
             */

            List<Veiculo> veiculos = new()
            {
                new Carro("Kia", 2016, 4),
                new Moto("Honda", 2018, 78),
                new Carro("Fiat", 2023, 4),
                new Moto("Yakuza", 2022, 100),
                new Moto("Hazaki", 2019, 120),
                new Carro("Chevrolet", 2018, 2)
            };

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.Apresentar();
            }
        }
    }
}