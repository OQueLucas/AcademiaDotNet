namespace Introducao.Exercicios.Funcoes
{
    internal class Exercicio8
    {
        // 8) Ler um número inteiro e passar por parâmetro para uma função e 0, se o número é par, ou 1, se o número é ímpar.

        public static bool ParImpar(int valor)
        {
            if (valor % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
