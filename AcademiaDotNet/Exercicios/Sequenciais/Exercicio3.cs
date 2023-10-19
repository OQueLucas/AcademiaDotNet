namespace AcademiaDotNet.Exercicios.Sequenciais
{
    internal class Exercicio3
    {
        // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os
        // valores de duas variáveis A e B.
        public static void TrocarValor()
        {
            string valor1, valor2, temporario;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Console.ReadLine();
            
            temporario = valor1;
            valor1 = valor2;
            valor2 = temporario;

            Console.WriteLine($"O primeiro valor agora é {valor1} e o segundo valor agora é {valor2}.");
        }
    }
}
