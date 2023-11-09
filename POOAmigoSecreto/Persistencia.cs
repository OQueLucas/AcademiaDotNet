using System.Text;

namespace POOAmigoSecreto
{
    internal class Persistencia
    {
        public static void CSVReader(List<Pessoa> pessoas)
        {
            try
            {
                string path = @"..\..\..\Data\amigos.csv";

                StreamReader streamReader = new(path, Encoding.UTF8);

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
            string path = @"..\..\..\Data\amigos.csv";

            StreamWriter streamWriter = File.Exists(path) ? File.AppendText(path) : File.CreateText(path);

            streamWriter.WriteLine(pessoa.Nome + ";" + pessoa.Email);

            streamWriter.Close();
        }

        public static void GerarAmigos(List<Pessoa> pessoas)
        {
            try
            {
                CSVReader(pessoas);

                Random rng = new();

                List<Pessoa> amigos = pessoas.OrderBy(a => rng.Next()).ToList();

                List<Pessoa> amigoOculto = amigos.ToList();

                amigoOculto.Reverse();

                string path = @"..\..\..\Data\secretos.csv";

                StreamWriter streamWriter = File.CreateText(path);

                for (int i = 0; i < amigos.Count; i++)
                {
                    string amigoSecreto = amigos[i] + ";" + amigoOculto[i];
                    Console.WriteLine(amigoSecreto);
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
