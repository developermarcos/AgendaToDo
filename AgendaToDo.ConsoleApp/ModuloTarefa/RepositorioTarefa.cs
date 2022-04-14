using AgendaToDo.ConsoleApp.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public override string Editar(int numeroEdicao, Tarefa item)
        {
            Tarefa tarefaEditada = ObterRegistro(numeroEdicao);

            Tarefa tarefa = new Tarefa(item.prioridade, item.titulo, tarefaEditada.dataCriacao, item.dataTermino, item.itens);

            return base.Editar(numeroEdicao, tarefa);
        }

        public List<Tarefa> ObterTarefasPendentes()
        {
            List<Tarefa> tarefasPedentes = new List<Tarefa>();

            foreach (Tarefa tarefa in registros)
            {
                if (!tarefa.EstaConcluida())
                    tarefasPedentes.Add(tarefa);
            }

            return ObterListaOrdenadaPrioridade(tarefasPedentes);
        }

        public List<Tarefa> ObterTarefasConcluidas()
        {
            List<Tarefa> tarefasConcluidas = new List<Tarefa>();

            foreach(Tarefa tarefa in registros)
            {
                if(tarefa.EstaConcluida())
                    tarefasConcluidas.Add(tarefa);
            }

            return ObterListaOrdenadaPrioridade(tarefasConcluidas);
        }
        private List<Tarefa> ObterListaOrdenadaPrioridade(List<Tarefa> tarefas)
        {
            List<Tarefa> tarefasOrdenadas = tarefas.OrderByDescending(m => (int)m.prioridade).ToList();

            return tarefasOrdenadas;
        }
    }
}
