using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Numero { get; set; }

        public abstract override string ToString();
    }
}
