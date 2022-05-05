using Dominio.ToDo.ModuloCompromisso;
using Dominio.ToDo.ModuloContato;
using Dominio.ToDo.ModuloTarefa;
using System;
using System.Collections.Generic;

namespace Infra.ToDo.Compartilhado
{
    [Serializable]
    public class DataContext
    {
        public List<Contato> Contatos;
        public List<Compromisso> Compromissos;
        public List<Tarefa> Tarefas;
        
    }
}
