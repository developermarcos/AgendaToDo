using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Dominio.ToDo.Compartilhado.Serializador
{
    public class SerializadoEmJson<T> : ISerializador<T>
    {
        private const string caminho = "teste";
        public string caminhoArquivo => caminho;

        public List<T> CarregarRegistrosDoArquivo()
        {
            if(!File.Exists(caminhoArquivo))
                return new List<T>();

            string registrosDeserializados = File.ReadAllText(caminhoArquivo);

            return JsonSerializer.Deserialize<List<T>>(registrosDeserializados);
        }

        public void GravarRegistrosEmArquivo(List<T> registros)
        {
            string registrosSerializados = JsonSerializer.Serialize(registros);

            File.WriteAllText(caminhoArquivo, registrosSerializados);
        }
    }
}
