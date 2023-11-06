namespace AbstracaoExercicio4
{
    internal abstract class ContaBancaria
    {
        protected ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        private double _saldo;

        public double Saldo { get { return _saldo; } set { _saldo = value; } }

        public abstract void Depositar(double amount);
        public abstract void Sacar(double amount);
    }
}
