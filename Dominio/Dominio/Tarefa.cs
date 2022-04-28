using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dominio
{
    public class Tarefa
    {
        public int numero { get; set; }
        public string descricao { get; set; }

        public List<ItemTarefa> itemTarefas { get; set; }
    }
}
