using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto
{
    internal class ConfiguracaoSingleton
    {
        // garantir que esta configuração seja unica, não abrindo ambiguiade
        private static ConfiguracaoSingleton instacia;

        private string _url { get; set; }
        private int _versao { get; set; }
        private int _porta { get; set; }

        public string Url { get { return _url; } }
        public int Versao { get { return _versao; } }
        public int Porta  { get { return _porta; } }

        private ConfiguracaoSingleton()
        {
            _url = "localhost";
            _versao = 1;
            _porta = 8080;
        }

        public static ConfiguracaoSingleton getInstance()
        {
            if (instacia == null)
                instacia = new ConfiguracaoSingleton();

            return instacia;
        }

        public void ExibirDados()
        {
            Console.WriteLine("URL: " + _url);
            Console.WriteLine("Versão: " + _versao);
            Console.WriteLine("Porta: " + _porta);
        }
    }
}
