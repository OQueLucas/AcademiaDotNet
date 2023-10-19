namespace AcademiaDotNet.Exercicios.Vetores
{
    internal class Exercicio3
    {
        // 3. Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
        public static void Primos()
        {
            int[] v = new int[20];

            Random rnd = new();


            for (int i = 0; i < v.Length; i++)
            {
                int cont = 0;

                //v[i] = int.Parse(Console.ReadLine());
                v[i] = i + 1;
                //v[i] = rnd.Next(20);

                for (int j = 1; j < v[i]; j++)
                {
                    if (v[i] % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 1)
                {
                    Console.WriteLine(Array.IndexOf(v, v[i]) + " ");
                }
            }


        }
    }
}
