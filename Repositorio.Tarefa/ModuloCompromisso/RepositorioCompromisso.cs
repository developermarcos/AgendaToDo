using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo.ModuloCompromisso;
using Infra.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso() : base(new SerializadorEmJsonNewton<Compromisso>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\compromissos.json"))
        {
        }
        public bool VerificarConflitoCompromissos(Compromisso compromisso)
        {
            foreach (var item in registros)
            {
                if (item.DataCompromisso == compromisso.DataCompromisso && compromisso.ExisteConflitoCompromissos(item))
                    return true;
            }
            return false;
        }
    }
}
