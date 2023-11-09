namespace AbstracaoExercicio6
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override void Sacar(double amount)
        {
            if (amount > Saldo)
            {
                return;
            }
            Saldo -= amount - 0.10;
        }

        public override void Depositar(double amount)
        {
            Saldo += amount;
        }
    }
}
