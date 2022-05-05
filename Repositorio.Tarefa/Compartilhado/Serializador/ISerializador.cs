using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.Compartilhado.Serializador
{
    public interface ISerializador<T>
    {
        List<T> CarregarRegistrosDoArquivo();
        void GravarRegistrosEmArquivo(List<T> registros);
    }
}
