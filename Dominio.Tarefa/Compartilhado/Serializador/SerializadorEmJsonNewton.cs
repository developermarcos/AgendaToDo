using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Dominio.ToDo;

namespace Dominio.ToDo.Compartilhado.Serializador
{
    public class SerializadorEmJsonNewton<T> : ISerializador<T>
    {
        private readonly string caminhoArquivo;

        public SerializadorEmJsonNewton(string caminho)
        {
            this.caminhoArquivo = caminho;
        }

        public List<T> CarregarRegistrosDoArquivo()
        {
            if (File.Exists(caminhoArquivo) == false)
                return new List<T>();

            string registrosJson = File.ReadAllText(caminhoArquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<T>>(registrosJson, settings);
        }

        public void GravarRegistrosEmArquivo(List<T> registros)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string registrosJson = JsonConvert.SerializeObject(registros, settings);

            File.WriteAllText(caminhoArquivo, registrosJson);
        }
    }
}
