﻿namespace OrientacaoObjeto.Desafios.Player
{
    internal class Musica
    {
        // 7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
        // Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist.
        // Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música).
        // Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.

        public string nome;
        public string autor;
        public string gravadora;

        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }

        public override string ToString()
        {
            return nome + " - " + autor + " - " + gravadora;
        }
    }
}
