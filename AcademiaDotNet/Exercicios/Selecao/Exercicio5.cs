namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio5
    {
        // 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
        // se a média das duas notas for maior ou igual a 7,0. 

        // Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
        // é a média entre a nota do exame e a média das 2 notas.
        // Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve
        // escrever “Reprovado”.

        public static void Aprovacao()
        {
            Console.WriteLine("Insira a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) /2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Insira a nota do exame: ");
                float exame = float.Parse(Console.ReadLine());
                media = (media + exame) /2;
                if (media >= 5)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
        }
    }
}
