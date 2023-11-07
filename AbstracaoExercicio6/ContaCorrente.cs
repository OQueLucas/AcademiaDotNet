namespace AbstracaoExercicio6
{
    internal class ContaCorrente : ContaBancaria
    {
        private int count = 0;
        public override void Sacar(double amount)
        {
            
            if (amount > Saldo) return;

            if (count == 0)
            {
                Saldo -= amount;
            } 
            else
            {
                Saldo -= amount - 0.05;
            }

            count++;
        }

        public override void Depositar(double amount)
        {
            Saldo += amount;
            Console.WriteLine("Saldo: "+Saldo);
        }
    }
}
