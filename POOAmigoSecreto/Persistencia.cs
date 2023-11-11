using System.Text;

namespace POOAmigoSecreto
{
    internal class Persistencia
    {
        static readonly string pathPessoas = @"..\..\..\Data\pessoas.csv";
        static readonly string pathAmigoSecreto = @"..\..\..\Data\amigoSecreto.csv";

        public static void CSVReader(List<Pessoa> pessoas)
        {
            try
            {

                StreamReader streamReader = new(pathPessoas, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    if (!pessoas.Contains(pessoa))
                    {
                        pessoas.Add(pessoa);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Não foi possível abrir o arquivo.");
            }
        }

        public static void CSVWriter(Pessoa pessoa)
        {
            try
            {
                StreamWriter streamWriter = File.Exists(pathPessoas) ? File.AppendText(pathPessoas) : File.CreateText(pathPessoas);

                streamWriter.WriteLine(pessoa);

                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CSVWriter(List<AmigoSecreto> listAmigosSecretos)
        {
            try
            {
                StreamWriter streamWriter = File.CreateText(pathAmigoSecreto);
                foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
                {
                    streamWriter.WriteLine(amigoSecreto);
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
