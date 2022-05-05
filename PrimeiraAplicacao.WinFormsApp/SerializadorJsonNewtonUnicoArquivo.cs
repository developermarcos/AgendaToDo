using Infra.ToDo.Compartilhado;
using Infra.ToDo.Compartilhado.Serializador;
using Newtonsoft.Json;
using System.IO;

namespace Apresentacao.ToDo
{
    public class SerializadorJsonNewtonUnicoArquivo : ISerializador
    {
        private protected string caminhoArquivo = "C:/Users/marco/source/repos/AgendaToDo/Repositorio.Tarefa/Data/data.json";
        public DataContext CarregarRegistrosDoArquivo()
        {
            if (File.Exists(caminhoArquivo) == false)
                return new DataContext();

            string registrosJson = File.ReadAllText(caminhoArquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            DataContext data = JsonConvert.DeserializeObject<DataContext>(registrosJson, settings);
            if (data == null)
                return new DataContext();

            return data;
        }

        public void GravarRegistrosEmArquivo(DataContext data)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string registrosJson = JsonConvert.SerializeObject(data, settings);

            File.WriteAllText(caminhoArquivo, registrosJson);
        }
    }
}