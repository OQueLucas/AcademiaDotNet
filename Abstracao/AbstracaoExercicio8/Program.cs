namespace AbstracaoExercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números. 
             * Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.
             */

            Calculadora.Somar(6, 3);
            Calculadora.Somar(6, 3, 6);

            Calculadora.Subtrair(6, 3, 6);
            Calculadora.Subtrair(3, 5);

            Calculadora.Multiplicar(3, 6);
            Calculadora.Multiplicar(5, 6, 2.2);

            Calculadora.Dividir(10, 3);
            Calculadora.Dividir(20, 4, 3.4);
        }
    }
}