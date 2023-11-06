namespace AbstracaoExercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar". 
             * Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e
             * saque de acordo com as regras de cada tipo de conta.*/

            ContaPoupanca poupanca = new(2400);
            Console.WriteLine(poupanca.Saldo);
            poupanca.Sacar(364.32);
            Console.WriteLine(poupanca.Saldo);
            poupanca.Sacar(5000);
            Console.WriteLine(poupanca.Saldo);
            poupanca.Depositar(432);
            Console.WriteLine(poupanca.Saldo);

            Console.WriteLine();

            ContaCorrente corrente = new(421);
            Console.WriteLine(corrente.Saldo);
            corrente.Sacar(32);
            Console.WriteLine(corrente.Saldo);
            corrente.Sacar(700);
            Console.WriteLine(corrente.Saldo);
            corrente.Depositar(64);
            Console.WriteLine(corrente.Saldo);
        }
    }
}