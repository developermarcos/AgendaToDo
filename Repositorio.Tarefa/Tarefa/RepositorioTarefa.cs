using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo;



namespace Infra.ToDo
{
    public class RepositorioTarefa
    {

        private readonly ISerializador<Tarefa> serializador;
        List<Tarefa> tarefas;
        private int contador = 0;

        public RepositorioTarefa(ISerializador<Tarefa> serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarRegistrosDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarRegistrosEmArquivo(tarefas);
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }

            serializador.GravarRegistrosEmArquivo(tarefas);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);

            serializador.GravarRegistrosEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarRegistrosEmArquivo(tarefas);
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

            serializador.GravarRegistrosEmArquivo(tarefas);
        }



    }
}
