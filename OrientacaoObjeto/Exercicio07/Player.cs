namespace OrientacaoObjeto.Exercicio07
{
    internal class Player
    {
        Playlist mp3Player = new();

        public void Musica()
        {
            mp3Player.NovaPlaylist();

            mp3Player.AdicionarMusica("November Rain", "Gun's Roses", "Geffen Records");
            mp3Player.AdicionarMusica("Don't Cry", "Gun's Roses", "Geffen Records");
            mp3Player.AdicionarMusica("Welcome to the Jungle", "Gun's Roses", "Geffen Records");
            mp3Player.AdicionarMusica("Sweet Child O' Mine", "Bon Jovi", "Geffen Records");
            mp3Player.AdicionarMusica("Livin' on a Prayer", "Bon Jovi", "Mercury Records");
            mp3Player.AdicionarMusica("You Give Love a Bad Name", "Bon Jovi", "Mercury Records");
            mp3Player.AdicionarMusica("It's My Life", "Bon Jovi", "Island");
            mp3Player.AdicionarMusica("Nothing Else Matters", "Metallica", "Sony Music");
            mp3Player.AdicionarMusica("Highway to Hell", "AC/DC", "Atlantic Records");
            mp3Player.AdicionarMusica("Enter Sandman", "Metallica", "Elektra Records");
            mp3Player.AdicionarMusica("Toxicity", "System Of A Down", "American Recordings ");
            mp3Player.AdicionarMusica("Numb", "Linkin Park", "Warner Bros., Machine Shop ");
            mp3Player.AdicionarMusica("I Love Rock 'N Roll", "Joan Jett & The Blackhearts", "RAK Records ");
            mp3Player.AdicionarMusica("I Hate Myself for Loving You", "Joan Jett And The Blackhearts", "Blackheart");
            mp3Player.AdicionarMusica("I Was Made For Lovin' You", "Kiss", "Casablanca");
            mp3Player.AdicionarMusica("Bad Medicine", "Bon Jovi", "Mercury");
            mp3Player.AdicionarMusica("Master Of Puppets", "Metallica", "New Electric Way, Music for Nations, Elektra");

            mp3Player.ExibirPlaylist();

            mp3Player.Tocar();
        }
    }
}
