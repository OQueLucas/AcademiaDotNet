namespace AcademiaDotNet.ExerciciosSequenciais
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
            float saque = 278.00F;
            int nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota1 = 0;
            while (saque > 0)
            {
                if (saque >= 50)
                {
                    nota50++;
                    saque -= 50;

                }
                else if (saque >= 20)
                {
                    nota20++;
                    saque -= 20;

                }
                else if (saque >= 10)
                {
                    nota10++;
                    saque -= 10;
                }
                else if (saque >= 5)
                {
                    nota5++;
                    saque -= 5;
                }
                else if (saque >= 1)
                {
                    nota1++;
                    saque -= 1;
                }
            }

            Console.WriteLine("Foi sacado: ");
            Console.WriteLine($"foi sacado: {nota50} notas de 50.");
            Console.WriteLine($"foi sacado: {nota20} notas de 20.");
            Console.WriteLine($"foi sacado: {nota10} notas de 10.");
            Console.WriteLine($"foi sacado: {nota5} notas de 5.");
            Console.WriteLine($"foi sacado: {nota1} notas de 1.");
        }
    }
}
