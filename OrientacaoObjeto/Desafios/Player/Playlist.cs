using System.Collections.Generic;

namespace OrientacaoObjeto.Desafios.Player
{
    internal class Playlist
    {
        // 7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
        // Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist.
        // Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música).
        // Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

        public string? nomePlaylist;
        public string? donoDaPlaylist;
        public List<Musica> playlist = new();

        public Playlist()
        {
        }

        public void AdicionarMusica(string nome, string autor, string gravadora)
        {
            playlist.Add(new(nome, autor, gravadora));
        }

        public void CadastrarMusica()
        {
            Console.WriteLine("Qual o nome da música: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o nome do autor/banda: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Qual a gravadora: ");
            string gravadora = Console.ReadLine();

            AdicionarMusica(nome, autor, gravadora);
        }

        public void NovaPlaylist()
        {
            string opcao;
            Console.WriteLine("Digite um nome pra playlist: ");
            nomePlaylist = Console.ReadLine();
            Console.WriteLine("Digite o nome do dono da playlist: ");
            donoDaPlaylist = Console.ReadLine();

            Console.WriteLine("Deseja adicionar uma música: ");
            Console.WriteLine("S (Sim) / N (Não)");

            opcao = Console.ReadLine().ToUpper();

            while (opcao == "S")
            {
                CadastrarMusica();

                Console.WriteLine("Deseja adicionar outra música: ");
                Console.WriteLine("S (Sim) / N (Não)");

                opcao = Console.ReadLine().ToUpper();
            };
        }

        public void ExibirPlaylist()
        {
            Console.WriteLine("Playlist: " + nomePlaylist);
            Console.WriteLine("Criador: " + donoDaPlaylist);
            Console.WriteLine();
            int i = 1;
            foreach (var musica in playlist)
            {
                Console.Write(i + " - ");
                Console.WriteLine(musica);
                i++;
            }
            Console.WriteLine();
        }

        public void Tocar()
        {
            var tocadas = playlist;
            int total = playlist.Count;
            Random random = new();
            char continuar;


            for (int i = 0; i < total; i++)
            {
                int restantes = tocadas.Count;
                int tocar = random.Next(0, restantes);

                Console.Write("Tocando agora:  ");
                Console.WriteLine(tocadas[tocar].nome);
                tocadas.RemoveAt(tocar);

                Console.WriteLine();
                Console.WriteLine("Deseja escutar outra música? ");
                Console.WriteLine("S (Sim) / N (Não)");
                continuar = char.Parse(Console.ReadLine().ToUpper());

                if (continuar == 'N')
                {
                    break;
                }
            }
        }
    }
}
