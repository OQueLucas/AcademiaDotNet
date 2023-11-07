namespace AbstracaoExercicio6
{
    internal abstract class ContaBancaria
    {
        private double _saldo;

        public double Saldo { get => _saldo; set => _saldo = value; }

        public abstract void Depositar(double amount);

        public abstract void Sacar(double amount);
    }

}
