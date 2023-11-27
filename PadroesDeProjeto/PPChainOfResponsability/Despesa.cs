namespace PadroesDeProjeto.PPChainOfResponsability
{
    public class Despesa
    {
        private string _description;
        private double _valor;

        public Despesa(string description, double valor)
        {
            Description = description;
            Valor = valor;
        }

        public string Description { get => _description; set => _description = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}