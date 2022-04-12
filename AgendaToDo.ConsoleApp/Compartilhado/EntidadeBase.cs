using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int numero;
        public bool ativo;

        public abstract string Validar();
    }
}
