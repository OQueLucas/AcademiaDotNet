namespace Introducao.Exercicios.Repeticao2
{
    internal class Exercicio20
    {
        // 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
        // certa região, a qual coletou os seguintes dados referentes a cada habitante para
        // serem analisados:
        // - sexo(masculino e feminino)
        // - cor dos olhos(azuis, verdes ou castanhos)
        // - cor dos cabelos(louros, castanhos, pretos)
        // - idade

        // Faça um algoritmo que determine e escreva: 

        // - a maior idade dos habitantes
        // - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
        // e que tenham olhos verdes e cabelos louros.
        // O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

        public static void IBGE()
        {
            int idade, maiorIdade = 0, mulheresPadrão = 0;
            char sexo, corDosOlhos, corDosCabelos;


            while (true)
            {
                Console.Write("Insira o idade do habitante: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0) break;

                Console.Write("Insira o sexo do habitante: ");
                Console.WriteLine("F = feminino / M = Masculino");
                sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Insira a cor dos olhos: ");
                Console.WriteLine("A = Azul / V = Verde / C = Castanho");
                corDosOlhos = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Insira a cor dos cabelos: ");
                Console.WriteLine("L = Louro / C = Castanho / P = Preto");
                corDosCabelos = char.Parse(Console.ReadLine().ToUpper());

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                bool sexoFeminino = sexo == 'F' ? true : false;
                bool entre18E35anos = (idade >= 18 && idade <= 35) ? true : false;
                bool olhosVerdes = corDosOlhos == 'V' ? true : false;
                bool cabelosLouros = corDosCabelos == 'L' ? true : false;


                if (sexoFeminino && entre18E35anos && olhosVerdes && cabelosLouros)
                {
                    mulheresPadrão++;
                }
            }

            Console.WriteLine($"O habitante mais velho tem: {maiorIdade}.");
            Console.WriteLine($"E possui {mulheresPadrão} mulheres padrão.");
        }
    }
}
