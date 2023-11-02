namespace OrientacaoObjeto.Exercicio11
{
    internal class Carro
    {
        // 11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade".
        // Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) e
        // outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

        private string _modelo;
        private int _ano;
        private int _velocidade;

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }
        public int Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                _ano = value;
            }
        }
        public int Velocidade
        {
            get
            {
                return _velocidade;
            }
        }

        public void Acelerar()
        {
            _velocidade += 10;
        }

        public void Frear()
        {
            if (_velocidade >= 10)
            {
                _velocidade -= 10;
            }
            else
            {
                _velocidade = 0;
            }
        }
    }
}
