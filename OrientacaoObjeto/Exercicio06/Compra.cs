namespace OrientacaoObjeto.Exercicio06
{
    internal class Compra
    {
        // 6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código. 

        public List<RegistroDeCompras> compras = new();

        public void ExibirCompras()
        {
            Console.WriteLine("Compras: ");
            foreach (var compra in compras)
            {
                Console.WriteLine(
                    compra.produto
                    + "  \t\tValor unitário: " + compra.valor
                    + "  \t\tQte: " + compra.quantidade
                    + "  \t\tData: " + compra.dataDeCompra
                );
            }
            Console.WriteLine("------------------------");
        }

        public void AdicionarCompra(Produto produto, int quantidade)
        {
            RegistroDeCompras compra = new(DateTime.Now, produto, quantidade);
            produto.RemoverEstoque(quantidade);
            compras.Add(compra);
        }

        //public static void FazerCompra()
        //{
        //    Produto batata = new("batata", 2.14, 200);
        //    Produto cenoura = new("cenoura", 4.15, 200);
        //    Produto rapadura = new("rapadura", 17, 200);
        //    Produto gelatina = new("batata", 3.75, 200);

        //    batata.AdicionarEstoque(30);

        //    Compra novaCompra = new();

        //    novaCompra.AdicionarCompra(batata, 20);
        //    novaCompra.AdicionarCompra(cenoura, 25);
        //    novaCompra.AdicionarCompra(rapadura, 2);
        //    novaCompra.AdicionarCompra(gelatina, 40);
        //    novaCompra.ExibirCompras();
        //}
    }
}
