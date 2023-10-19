namespace AcademiaDotNet.Exercicios.Repeticao2
{
    internal class Exercicio10
    {
        // 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
        // Número de pessoas do sexo masculino.
        // Número de pessoas do sexo feminino.
        // Número de pessoas com idade inferior a 30 anos.
        // Número de pessoas com idade superior a 60 anos.
        // Média de idade das mulheres.

        public static void Dados()
        {
            int sexoMasculino = 0, sexoFeminino = 0, idadeInferior30 = 0, idadeSuperior60 = 0, mediaIdadeMulheres = 0, totalIdadeMulheres = 0;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Digite o nome da pessoa {i}:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Digite o sexo da pessoa {i} (M/F):");
                char sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine($"Digite a idade da pessoa {i}:");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    sexoMasculino++;
                }
                else if (sexo == 'F')
                {
                    sexoFeminino++;
                    totalIdadeMulheres += idade;
                }

                if (idade < 30)
                {
                    idadeInferior30++;
                }
                else if (idade > 60)
                {
                    idadeSuperior60++;
                }

            }
            mediaIdadeMulheres = totalIdadeMulheres / sexoFeminino;

            Console.WriteLine("Número de pessoas do sexo masculino: " + sexoMasculino);
            Console.WriteLine("Número de pessoas do sexo feminino: " + sexoFeminino);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + idadeInferior30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + idadeSuperior60);
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
        }
    }
}
