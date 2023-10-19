namespace AcademiaDotNet.Exercicios.Sequenciais
{
    internal class Exercicio10
    {
        // 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
        // para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
        // realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as 
        // notas de menor valor fossem distribuídas em número mínimo possível. 
        // Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
        // uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
        // Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
        // de acordo com o critério da “distribuição ótima”.
        public static void Saque()
        {
            int saque = 278;
            int nota50, nota20, nota10, nota5, nota1;

            nota50 = saque / 50;
            saque = saque - (nota50 * 50);

            nota20 = saque / 20;
            saque = saque - (nota20 * 20);

            nota10 = saque / 10;
            saque = saque - (nota10 * 10);

            nota5 = saque / 5;
            saque = saque - (nota5 * 5);

            nota1 = saque / 1;

            Console.WriteLine("Foi sacado: ");
            Console.WriteLine($"foi sacado: {nota50} notas de 50.");
            Console.WriteLine($"foi sacado: {nota20} notas de 20.");
            Console.WriteLine($"foi sacado: {nota10} notas de 10.");
            Console.WriteLine($"foi sacado: {nota5} notas de 5.");
            Console.WriteLine($"foi sacado: {nota1} notas de 1.");
        }
    }
}
