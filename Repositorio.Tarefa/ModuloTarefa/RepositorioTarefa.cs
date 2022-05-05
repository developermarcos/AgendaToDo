using System;
using System.Collections.Generic;
using System.Linq;
using Infra.ToDo.Compartilhado;
using Dominio.ToDo.ModuloTarefa;
using Infra.ToDo.Compartilhado.Serializador;

namespace Infra.ToDo.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBaseUnicoArquivo, IRepositorioTarefa
    {
        public RepositorioTarefa(DataContext contextBase, ISerializador serializador) : base(contextBase, serializador)
        {
            dataContext.Tarefas = serializador.CarregarRegistrosDoArquivo().Tarefas;

            if (dataContext.Tarefas != null && dataContext.Tarefas.Count > 0)
                contador = dataContext.Contatos.Max(x => x.Numero);

            if (dataContext.Tarefas == null)
                dataContext.Tarefas = new List<Tarefa>();
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarRegistrosEmArquivo(dataContext);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            serializador.GravarRegistrosEmArquivo(dataContext);
        }

        public string Editar(Tarefa registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Tarefas.RemoveAll(x => x.Numero == registro.Numero);

                dataContext.Tarefas.Add(registro);

                List<Tarefa> ordenarRegistros = dataContext.Tarefas;

                dataContext.Tarefas = ordenarRegistros.OrderBy(x => x.Numero).ToList();

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Excluir(Tarefa registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                dataContext.Tarefas.Remove(registro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public string Inserir(Tarefa novoRegistro)
        {
            string dadosValidos = "";
            if(dataContext.Tarefas != null)
            {
                foreach (var item in dataContext.Tarefas)
                {
                    if (item.Titulo == novoRegistro.Titulo)
                        dadosValidos =  "NOME_JA_UTILIZADO";
                }
            }

            dadosValidos += novoRegistro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                novoRegistro.Numero = ++contador;

                dataContext.Tarefas.Add(novoRegistro);

                serializador.GravarRegistrosEmArquivo(dataContext);
            }

            return dadosValidos;
        }

        public List<Tarefa> ObterListaOrdenadaPrioridade(List<Tarefa> tarefas)
        {
            if(tarefas!= null && tarefas.Count != 0)
                return tarefas.OrderByDescending(m => (int)m.prioridade).ToList();

             return new List<Tarefa>();
        }

        public List<Tarefa> SelecionarTodos()
        {
            return ObterListaOrdenadaPrioridade(dataContext.Tarefas);
        }

        public List<Tarefa> SelecionaTarefasConcluidas()
        {
            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            tarefasPendentes = dataContext.Tarefas.FindAll(x => x.CalcularPercentualConcluido() == 100);

            return ObterListaOrdenadaPrioridade(tarefasPendentes);
        }

        public List<Tarefa> SelecionaTarefasPendentes()
        {
            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            tarefasPendentes = dataContext.Tarefas.FindAll(x => x.CalcularPercentualConcluido() != 100);

            return ObterListaOrdenadaPrioridade(tarefasPendentes);
        }
    }
}
