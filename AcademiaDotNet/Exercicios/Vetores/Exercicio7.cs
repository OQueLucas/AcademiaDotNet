namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio7
    {
        // 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e
        // escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
        // a.lê: 		|7|40|3|9|21|0|63|31|7|22|
        // b.escreve: 	|40|0|22|7|3|9|21|63|31|7|
        public static void Ordenador()
        {
            int[] a = new int[10];
            int cont = 0, contPar = 0, contImpar = 0;
            Random rnd = new();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(byte.MaxValue);
                if (a[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(String.Join(" | ", a));
            int[] par = new int[cont];
            int[] impar = new int[10 - cont];
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    par[contPar] = a[i];
                    contPar++;
                }
                else
                {
                    impar[contImpar] = a[i];
                    contImpar++;
                }
            }
            int[] b = par.Concat(impar).ToArray();
            Console.WriteLine(String.Join(" | ", b));
        }
    }
}
