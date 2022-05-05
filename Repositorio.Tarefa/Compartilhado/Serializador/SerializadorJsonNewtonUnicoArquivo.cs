using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Dominio.ToDo;
using Dominio.ToDo.Compartilhado;

namespace Infra.ToDo.Compartilhado.Serializador
{
    public class SerializadorEmJsonNewton : ISerializador
    {
        private readonly string caminhoArquivo;

        public SerializadorEmJsonNewton()
        {
            this.caminhoArquivo = "C:/Users/marco/source/repos/AgendaToDo/Repositorio.Tarefa/Data/data.json";
        }

        public void GravarRegistrosEmArquivo(DataContext data)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string registrosJson = JsonConvert.SerializeObject(data, settings);

            File.WriteAllText(caminhoArquivo, registrosJson);
            
        }

        DataContext ISerializador.CarregarRegistrosDoArquivo()
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
    }
}
