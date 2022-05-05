using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Infra.ToDo.Compartilhado.Serializador
{
    public class SerializadorEmBits<T> : ISerializador<T>
    {
        private const string caminho = @"C:\temp\Ts.xml";
        public string caminhoArquivo { get => caminho; }

        public List<T> CarregarRegistrosDoArquivo()
        {
            if (File.Exists(caminhoArquivo) == false)
                return new List<T>();

            XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

            byte[] bytesTs = File.ReadAllBytes(caminhoArquivo);

            MemoryStream ms = new MemoryStream(bytesTs);

            return (List<T>)serializador.Deserialize(ms);
        }

        public void GravarRegistrosEmArquivo(List<T> Ts)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, Ts);

            byte[] bytesTs = ms.ToArray();

            File.WriteAllBytes(caminhoArquivo, bytesTs);
        }
    }
}
