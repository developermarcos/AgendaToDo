using Dominio.ToDo.ModuloCompromisso;
using Dominio.ToDo.ModuloContato;
using Dominio.ToDo.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.Compartilhado
{
    [Serializable]
    public class ContextBase
    {
        public List<Contato> Contatos;
        public List<Compromisso> Compromissos;
        public List<Tarefa> Tarefas;
    }
}
