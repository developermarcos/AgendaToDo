using AgendaToDo.ConsoleApp.Compartilhado;
using System.Collections.Generic;

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
    }
}
