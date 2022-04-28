using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.Compartilhado.Serializador
{
    public interface ISerializador<T>
    {
        string caminhoArquivo { get; }
        List<T> CarregarRegistrosDoArquivo();
        void GravarRegistrosEmArquivo(List<T> registros);
    }
}
