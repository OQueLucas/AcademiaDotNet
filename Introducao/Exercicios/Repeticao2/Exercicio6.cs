﻿namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio6
    {
        // 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
        // ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
        // Ao final, mostre a idade digitada.

        public static void Idade()
        {
            int idade;

            do
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
            } while (idade <= 0);
        }
    }
}
