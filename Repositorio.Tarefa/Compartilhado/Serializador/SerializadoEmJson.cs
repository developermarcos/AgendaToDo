using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Infra.ToDo.Compartilhado.Serializador
{
    public class SerializadoEmJson<T> : ISerializadorGenerico<T>
    {
        private readonly string caminhoArquivo = @"C:\temp\tarefa.bin";

        public SerializadoEmJson(string caminho)
        {
            caminhoArquivo = caminho;
        }
        
        public List<T> CarregarRegistrosDoArquivo()
        {
            if (File.Exists(caminhoArquivo) == false)
                return new List<T>();

            string registrosJson = File.ReadAllText(caminhoArquivo);

            return JsonSerializer.Deserialize<List<T>>(registrosJson);
        }

        public void GravarRegistrosEmArquivo(List<T> registros)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string registrosJson = JsonSerializer.Serialize(registros, config);

            File.WriteAllText(caminhoArquivo, registrosJson);
        }
    }
}
