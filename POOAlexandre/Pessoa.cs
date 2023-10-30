namespace POOAlexandre
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int Idade { get { return DateOnly.FromDateTime(DateTime.Now).Year - DataNascimento.Year; } }
        public string Sobrenome { get { string[] vetor = Nome.Split(); return vetor[vetor.Length - 1]; } }

        public Pessoa(string nome, string email, DateOnly dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public static bool EstaContido<T>(string email, List<T> lista) where T : Pessoa
        {
            foreach (var atleta in lista)
            {
                if (email == atleta.Email)
                {
                    return true;
                }
            }
            return false;
        }

        public static int PesquisaNomeEmail<T>(string pesquisa, List<T> lista) where T : Pessoa
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (pesquisa == lista[i].Email || lista[i].Nome.Contains(pesquisa))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
