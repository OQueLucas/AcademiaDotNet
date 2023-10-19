namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio6
    {
        // 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
        // a.lê: 		|7|40|3|9|21|0|63|31|7|22|
        // b.escreve: 	|22|7|31|63|0|21|9|3|40|7|
        public static void Inverter()
        {
            int[] a = new int[10];
            int[] b = new int[10];
            Random rnd = new();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(byte.MaxValue);
            }
            Console.WriteLine(String.Join(" | ", a));
            Console.WriteLine();
            for (int i = 0; a.Length > i; i++)
            {
                int j = a.Length - (i + 1);
                b[i] = a[j];
            }
            Console.WriteLine(String.Join(" | ", b));

        }
    }
}
