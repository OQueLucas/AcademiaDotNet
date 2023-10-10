namespace AcademiaDotNet.ExercicioVetores
{
    internal class Exercicio13
    {
        // 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas
        // vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa
        // quando for digitado -1 ou quando atingir o máximo de posições do vetor.
        public static void Contador()
        {
            int[] vetor = new int[100];
            int cont2 = 0, cont4 = 0, cont8 = 0;
            Random rnd = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                //vetor[i] = rnd.Next(100);
                Console.Write($"Insira o valor {i + 1}: ");
                bool b = int.TryParse(Console.ReadLine(), out int valor);

                if (valor == -1)
                {
                    break;
                }

                vetor[i] = valor;

                if (vetor[i] == 2)
                {
                    cont2++;
                }
                else if (vetor[i] == 4)
                {
                    cont4++;
                }
                else if (vetor[i] == 8)
                {
                    cont8++;
                }
            }
            Console.WriteLine(String.Join(" | ", vetor));

            Console.WriteLine(cont2);
            Console.WriteLine(cont4);
            Console.WriteLine(cont8);
        }
    }
}
