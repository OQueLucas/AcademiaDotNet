namespace OrientacaoObjeto.Exercicios
{
    internal class Personagem
    {
        // Crie uma classe chamada Personagem. Defina seus atributos, mas dentre eles deve conter: Nome, posição e itens coletados, no mínimo.
        // Crie construtor e faça a leitura dos atributos pelo teclado.
        // Crie um método chamado “atacar” que recebe por parâmetro uma variável do tipo double que indica o dano do ataque numa escala de 0 a 10.
        // O método deve apresentar uma mensagem na tela com o dano.
        // Crie um método chamado “movimentar” que deve receber por parâmetro uma variável do tipo int que indica a direção que o personagem vai se mover
        // (1 – frente, 2 – trás, 3 – direita e 4 – esquerda). O método deve apresentar uma mensagem na tela mostrando a direção que o personagem vai se mover.

        public string nome;
        public double forca = 1;
        public int[] posicao = new int[2] { 7, 7 };
        public char[,] mapa = new char[15, 15];
        public int[,] itens = new int[15, 2];
        public int itensColetados = 0;
        public bool ataque = false;

        public Personagem(string nome)
        {
            this.nome = nome;
        }

        public void Jogo()
        {
            GerarItens();

            Acao();
        }

        public void GerarItens()
        {
            for (int i = 0; i < itens.GetLength(0); i++)
            {
                Random rng = new Random();
                itens[i, 0] = rng.Next(1, 15);
                itens[i, 1] = rng.Next(1, 15);
                Console.WriteLine(itens[i, 0] + " " + itens[i, 1]);
            }
        }

        public bool Atacar(double dano)
        {
            Random rng = new();
            int d20 = rng.Next(1, 21);
            double danoCrit = 0;

            ConsoleColor color = Console.ForegroundColor;


            if (d20 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falha crítica!");
                Console.WriteLine("Errou o alvo!");
                Console.ForegroundColor = color;
                return false;
            }
            else if (d20 == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                danoCrit = dano;
                Console.WriteLine("Acerto crítico!");
            }

            Console.WriteLine("D20: " + d20);
            Console.Write($"Ataque causou {dano}" + (danoCrit != 0 ? $" mais {danoCrit} de dano crítico.\nTotal: {dano + danoCrit}" : ""));
            Console.WriteLine();
            Console.ForegroundColor = color;
            return true;
        }

        public void Movimento(string movimento)
        {
            if ((movimento == "1" || movimento == "W") && posicao[0] != 0)
            {
                Console.WriteLine("frente");
                posicao[0] -= 1;
            }
            else if ((movimento == "2" || movimento == "S") && posicao[0] != 14)
            {
                Console.WriteLine("tras");
                posicao[0] += 1;
            }
            else if ((movimento == "3" || movimento == "D") && posicao[1] != 14)
            {
                Console.WriteLine("direita");
                posicao[1] += 1;
            }
            else if ((movimento == "4" || movimento == "A") && posicao[1] != 0)
            {
                Console.WriteLine("esquerda");
                posicao[1] -= 1;
            }

        }

        public void Acao()
        {
            bool end = false;

            while (!end)
            {
                Console.Clear();
                Console.WriteLine($"J: {nome}. Força: {forca}");
                Mapa();

                ConsoleKeyInfo input = Console.ReadKey();
                Console.WriteLine();

                if (input.Key == ConsoleKey.Enter)
                {
                    end = true;
                }
                else if (input.Key == ConsoleKey.Spacebar)
                {
                    ataque = true;
                }

                string movimento = input.KeyChar.ToString().ToUpper();
                Movimento(movimento);
                ColetaItem();
            }
        }

        private void ColetaItem()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                if (posicao[0] == itens[i, 0] && posicao[1] == itens[i, 1])
                {
                    itensColetados++;
                    forca += 0.5;
                    itens[i, 0] = 17;
                    itens[i, 1] = 17;
                }
            }
        }

        public void Mapa()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    if (i == posicao[0] && j == posicao[1])
                    {
                        mapa[i, j] = 'J';
                    }
                    else
                    {
                        mapa[i, j] = '-';
                    }

                    for (int k = 0; k < itens.GetLength(0); k++)
                    {
                        if (i == itens[k, 0] && j == itens[k, 1])
                        {
                            mapa[i, j] = 'I';
                        }
                    }

                    Console.Write(mapa[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Itens coletados: " + itensColetados);

            if (ataque)
            {
                Atacar(forca);
            }


            ataque = false;
        }
    }
}
