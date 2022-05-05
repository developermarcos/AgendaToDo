using System;
using System.Collections.Generic;
using System.Linq;
using Infra.ToDo.Compartilhado.Serializador;
using Dominio.ToDo.ModuloTarefa;
using Infra.ToDo.Compartilhado;



namespace Infra.ToDo.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa() 
            : base(new SerializadorEmJsonNewton<Tarefa>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\tarefas.json"))
        {
        }
        public override List<Tarefa> SelecionarTodos()
        {
            return ObterListaOrdenadaPrioridade(registros);
        }
        public override string Inserir(Tarefa novoRegistro)
        {
            string dadosValidos = "";
            foreach (var item in registros)
            {
                if (item.Titulo == novoRegistro.Titulo)
                    dadosValidos =  "NOME_JA_UTILIZADO";
            }
            
            dadosValidos += novoRegistro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                novoRegistro.Numero = ++contador;

                registros.Add(novoRegistro);

                serializador.GravarRegistrosEmArquivo(registros);
            }

            return dadosValidos;
        }
        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarRegistrosEmArquivo(registros);
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

            serializador.GravarRegistrosEmArquivo(registros);
        }
        public List<Tarefa> SelecionaTarefasPendentes()
        {
            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            tarefasPendentes = registros.FindAll(x => x.CalcularPercentualConcluido() != 100);

            return ObterListaOrdenadaPrioridade(tarefasPendentes);
        }
        public List<Tarefa> SelecionaTarefasConcluidas()
        {
            List<Tarefa> tarefasPendentes = new List<Tarefa>();

            tarefasPendentes = registros.FindAll(x => x.CalcularPercentualConcluido() == 100);

            return ObterListaOrdenadaPrioridade(tarefasPendentes);
        }
        private List<Tarefa> ObterListaOrdenadaPrioridade(List<Tarefa> tarefas)
        {
            List<Tarefa> tarefasOrdenadas = tarefas.OrderByDescending(m => (int)m.prioridade).ToList();

            return tarefasOrdenadas;
        }

    }
}
