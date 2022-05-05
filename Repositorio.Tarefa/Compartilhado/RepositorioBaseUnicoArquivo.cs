using Dominio.ToDo.Compartilhado;
using Infra.ToDo.Compartilhado.Serializador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.Compartilhado
{
    public abstract class RepositorioBaseUnicoArquivo
    {
        public int contador;
        public DataContext dataContext;
        public ISerializador serializador;
        public RepositorioBaseUnicoArquivo(DataContext contextBase, ISerializador serializador)
        {
            this.dataContext=contextBase;
            this.serializador=serializador;
        }
    }
}
