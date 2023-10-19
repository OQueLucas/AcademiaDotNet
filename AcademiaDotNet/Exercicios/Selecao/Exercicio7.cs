namespace AcademiaDotNet.Exercicios.Selecao
{
    internal class Exercicio7
    {
        // 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
        // O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
        // exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.

        public static void Frase()
        {
            string frase = "Gatos não são nossos animais de estimação, nós é que somos os animais de estimação deles.";
            string palavra = "Gat";

            bool contem = frase.Contains(palavra);

            if (contem)
            {
                Console.WriteLine("A palavra encontra-se na frase.");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase.");
            }
        }
    }
}
