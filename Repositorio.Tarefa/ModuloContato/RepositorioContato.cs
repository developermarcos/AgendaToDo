using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo.ModuloContato;
using Infra.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato() : base(new SerializadorEmJsonNewton<Contato>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\contatos.json"))
        {
        }
    }
}
