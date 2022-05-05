using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.ModuloTarefa
{
    public interface IRepositorioTarefa
    {
        List<Tarefa> SelecionarTodos();
        string Inserir(Tarefa novoRegistro);

        string Editar(Tarefa registro);

        string Excluir(Tarefa registro);

        void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens);

        void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);

        List<Tarefa> SelecionaTarefasPendentes();

        List<Tarefa> SelecionaTarefasConcluidas();

        List<Tarefa> ObterListaOrdenadaPrioridade(List<Tarefa> tarefas);
        
    }
}
