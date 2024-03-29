﻿namespace Introducao.Exercicios.Selecao
{
    internal class Exercicio15
    {
        // 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
        // da área a ser pintada.Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
        // e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
        // Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

        public static void Tintuaria()
        {
            Console.WriteLine("Qual o tamanho em metros quadrados da área a ser pintada: ");
            float metrosQuadrados = float.Parse(Console.ReadLine());
            float litros = metrosQuadrados / 3;
            float latas = litros / 18;
            latas = (int)Math.Ceiling(latas);
            float precoTotal = latas * 80;

            Console.WriteLine($"Quantidade de latas necessárias é: {latas} e o preço total é R$ {precoTotal}");
        }
    }
}
