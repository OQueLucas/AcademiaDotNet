using System.Globalization;

namespace OrientacaoObjeto.Exercicios
{
    internal class Pessoa
    {
        // Crie uma classe chamada Pessoa com seus atributos conforme sua preferência(Nome, CPF, data de nascimento, RG etc).
        // Crie métodos para cadastrar e apresentar na tela os dados desta classe.

        public string nome;
        public string cpf;
        public DateOnly nascimento;
        public string rg;

        public void CadastrarPessoa()
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF (sem pontuação): ");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: ");
            nascimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero do RG (sem pontuação): ");
            rg = Console.ReadLine();

            Console.WriteLine(ApresentaPessoa());
        }

        public string ApresentaPessoa()
        {

            return $"{nome} nasceu em {nascimento} com CPF {cpf} e RG {rg}.";
        }
    }
}
