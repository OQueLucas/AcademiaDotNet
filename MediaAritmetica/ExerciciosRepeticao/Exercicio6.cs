namespace AcademiaDotNet.ExerciciosRepeticao
{
    internal class Exercicio6
    {
        // 6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
        // aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
        // (média das notas das avaliações). 

        public static void NotaAlunos()
        {
            Console.WriteLine("Insira a quantidade de alunos dessa turma: ");
            int alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de avaliações aplicadas para essa turma: ");
            int avaliacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alunos; i++)
            {
                int nota;
                int total = 0;
                int media;

                for (int j = 1; j <= avaliacoes; j++)
                {
                    Console.WriteLine($"Insira a nota da avaliacao {j} do aluno {i}:");
                    nota = int.Parse(Console.ReadLine());

                    total += nota;
                }
                media = total / avaliacoes;
                Console.WriteLine($"O aluno {i} está com {media} de media!");
            }
        }
    }
}
