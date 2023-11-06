namespace AbstracaoExercicio4
{
    internal class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(double saldo) : base(saldo)
        {
        }

        public override void Depositar(double amount)
        {
            Saldo += amount;
        }

        public override void Sacar(double amount)
        {
            if (amount > Saldo)
            {
                Console.WriteLine("Tentativa de sacar valor excedendo saldo!");
                return;
            }
            Saldo -= amount;
        }
    }
}
