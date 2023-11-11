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

        public static void CSVWriter(string path, Pessoa pessoa)
        {
            StreamWriter streamWriter = File.Exists(path) ? File.AppendText(path) : File.CreateText(path);

            streamWriter.WriteLine(pessoa);

            streamWriter.Close();
        }

        public static void GerarAmigos(List<Pessoa> pessoas)
        {
            try
            {
                CSVReader(pessoas);

                Random rng = new();

                List<Pessoa> listPessoas = pessoas.OrderBy(a => rng.Next()).ToList();

                List<Pessoa> listAmigos = listPessoas.ToList();

                List<AmigoSecreto> listAmigosSecretos = new();

                string path = @"..\..\..\Data\secretos.csv";

                foreach (Pessoa pessoa in listPessoas)
                {
                    int random = rng.Next(0, listAmigos.Count);
                    Pessoa amigo = listAmigos.ElementAt(random);

                    if (pessoa != amigo)
                    {
                        listAmigosSecretos.Add(new(pessoa, amigo));
                        listAmigos.Remove(amigo);
                    }
                    else
                    {
                        throw new Exception($"Gere novamente, alguém tirou a si mesmo");
                    }
                }
                StreamWriter streamWriter = File.CreateText(path);
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
