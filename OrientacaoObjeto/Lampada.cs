namespace OrientacaoObjeto
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;
        public string cor;

        public Lampada(bool ligada, double potencia, string cor)
        {
            this.ligada = ligada;
            this.potencia = potencia;
            this.cor = cor;
        }

        public void Ligar()
        {
            if (ligada)
            {
                Console.WriteLine("Lampada já está ligada!");
            }
            else
            {
                Console.WriteLine("Ligando lampada!");
                ligada = true;
            }
        }

        public void Desligar()
        {
            if (!ligada)
            {
                Console.WriteLine("Lampada já está desligada!");
            }
            else
            {
                Console.WriteLine("Desligando lampada!");
                ligada = false;
            }
        }

        public bool EstaLigada()
        {
            return ligada;
        }
    }
}
