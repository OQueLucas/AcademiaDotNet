namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio4
    {
        // 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
        // Mostrar na tela qual dos professores tem o maior salário total.
        public static void salarioHora()
        {
            Console.WriteLine("Insira a quantidade de horas aula do primeiro professor: ");
            int horaProfessor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor recebido por hora: ");
            double valorProfessor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas aula do segundo professor: ");
            int horaProfessor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor recebido por hora: ");
            double valorProfessor2 = double.Parse(Console.ReadLine());

            double salarioProfessor1 = horaProfessor1 * valorProfessor1;
            double salarioProfessor2 = horaProfessor2 * valorProfessor2;

            if (salarioProfessor1 > salarioProfessor2)
            {
                Console.WriteLine("O salário do professor 1 é maior!");
            }
            else if (salarioProfessor2 > salarioProfessor1)
            {
                Console.WriteLine("O salário do professor 2 é maior!");
            }
            else
            {
                Console.WriteLine("O salário dos dois professores são equivalentes!");
            }
        }
    }
}
