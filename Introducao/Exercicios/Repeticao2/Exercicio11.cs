namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio11
    {
        // 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
        // a média aritmética da turma e a quantidade de alunos da turma.Usar -1 para encerrar a leitura.

        public static void Notas()
        {
            float nota = 0;
            float notaMaisAlta = 0, notaMaisBaixa = 10, total = 0, media;
            int quantidadeAlunos = 0;
            int i = 1;

            while (nota != -1)
            {

                Console.Write($"Insira a nota do {i}º aluno: ");
                float.TryParse(Console.ReadLine(), out nota);

                if (nota == -1)
                {
                    continue;
                }

                if (nota > notaMaisAlta)
                {
                    notaMaisAlta = nota;
                }
                if (nota < notaMaisBaixa)
                {
                    notaMaisBaixa = nota;
                }

                total += nota;

                quantidadeAlunos++;
                i++;
            }

            media = total / quantidadeAlunos;

            Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
            Console.WriteLine("Nota mais alta: " + notaMaisAlta);
            Console.WriteLine("Nota media da turma: " + media);
            Console.WriteLine("Quantidade de alunos: " + quantidadeAlunos);
        }
    }
}
