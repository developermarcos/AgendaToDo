using Dominio.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.Compartilhado.Serializador
{
    public interface ISerializador
    {
        DataContext CarregarRegistrosDoArquivo();
        void GravarRegistrosEmArquivo(DataContext data);
    }
}
