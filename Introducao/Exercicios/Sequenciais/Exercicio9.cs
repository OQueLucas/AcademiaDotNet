﻿namespace Introducao.Exercicios.Sequenciais
{
    internal class Exercicio9
    {
        // 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
        // ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
        // Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
        // se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
        // Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
        // da entrada e das duas prestações, de acordo com as regras acima.
        // Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
        // conseqüente pagamento dos boletos das duas prestações.

        public static void Prestacao()
        {
            float valorMercadoria = 302.75F;

            float resto = valorMercadoria % 3;
            float prestacoes = (valorMercadoria - resto) / 3;
            float entrada = prestacoes + resto;

            Console.WriteLine($"A entrada da entrada ficará em R$ {entrada} e as prestações de R$ {prestacoes}.");

        }
    }
}
