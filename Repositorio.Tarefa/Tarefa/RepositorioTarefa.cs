using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo;
using Infra.ToDo.Compartilhado;



namespace Infra.ToDo
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa() 
            : base(new SerializadorEmJsonNewton<Tarefa>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\tarefas.json"))
        {
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarRegistrosEmArquivo(registros);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            serializador.GravarRegistrosEmArquivo(registros);
        }



    }
}
