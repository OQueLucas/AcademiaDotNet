namespace AcademiaDotNet.ExerciciosSelecao
{
    internal class Exercicio12
    {
        // 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
        // número de horas trabalhadas de um operário.Na sequência, calcule o salário sabendo-se que ele ganha
        // R$ 10,00 por hora.Quando o número de horas exceder a 50 calcule o excesso de pagamento
        // armazenando-o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00. 
        // No final do processamento, exibir o salário total e o salário excedente do operário.

        public static void Salario()
        {
            Console.WriteLine("Digite o codigo do operário: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Digite o numero de horas do operário: ");
            int numeroHoras = int.Parse(Console.ReadLine());

            int extra = 0;

            if (numeroHoras > 50)
            {
                extra = numeroHoras - 50;
                numeroHoras -= extra;
            }

            int salarioExtra = extra * 20;
            int salario = numeroHoras * 10;

            Console.WriteLine($"O salário total do operário codigo {codigo} é R$ {salario}, e o salário excedente é R$ {salarioExtra}.");
        }
    }
}
