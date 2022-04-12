using AgendaToDo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;


namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public enum TipoDado { Cadastro, Edicao}
    public class TelaTarefa : TelaBase, ICadastroBase
    {
        Notificador notificador;
        RepositorioTarefa repositorioTarefa;
        public TelaTarefa(Notificador notificador, RepositorioTarefa repositorioTarefa) : base("Tela Tarefa")
        {
            this.notificador = notificador;
            this.repositorioTarefa = repositorioTarefa;
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando nova tarefa");

            bool temTarefaCadastrada = VisualizarRegistros("Pesquisando");

            if (!temTarefaCadastrada)
            {
                notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar", TipoMensagem.Atencao);
                return;
            }

            int idTarefa = ObterNumeroTarefa();

            Tarefa novaTarefa = ObterTarefa(TipoDado.Edicao);

            string mensagemValidacao = repositorioTarefa.Editar(idTarefa, novaTarefa);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem("Tarefa não inserida, erro na validação dos campos", TipoMensagem.Erro);
        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo nova tarefa");

            bool temTarefaCadastrada = VisualizarRegistros("Pesquisando");

            if (!temTarefaCadastrada)
            {
                notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar", TipoMensagem.Atencao);
                return;
            }

            int idTarefa = ObterNumeroTarefa();

            repositorioTarefa.Excluir(idTarefa);

            notificador.ApresentarMensagem("Tarefa excluída com sucesso!", TipoMensagem.Sucesso);
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo nova tarefa");

            Tarefa novaTarefa = ObterTarefa(TipoDado.Cadastro);

            string mensagemValidacao = repositorioTarefa.Inserir(novaTarefa);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem("Tarefa não inserida, erro na validação dos campos", TipoMensagem.Erro);
        }

        public bool VisualizarRegistros(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de Tarefa");

            List<Tarefa> tarefas = repositorioTarefa.ObterTodosRegistros();

            if (tarefas.Count == 0)
                return false;

            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(tarefa.ToString());

                Console.WriteLine();
            }

            return true;
        }


        #region métodos privados

        private Tarefa ObterTarefa(TipoDado tipoDado)
        {
            Console.WriteLine("Níveis de prioridade 1- Baixo | 2- Média | 3- Alta");
            Console.Write("Informe a prioridade: ");
            Prioridade prioridade = (Prioridade)Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o titulo : ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Modelo de data esperado 00/00/0000");

            DateTime dataInicio = default;
            if (tipoDado == TipoDado.Cadastro)
                dataInicio = ObterData("Informe a data de criação: ");
            
            DateTime dataFim = ObterData("Informe a data de finalização: ");

            List<Item> itens = ObterListaItens();

            if (tipoDado == TipoDado.Cadastro)
                return new Tarefa(prioridade, titulo, dataInicio, dataFim, itens);
            
            else
                return new Tarefa(prioridade, titulo, dataFim, itens);
            
        }

        private int ObterNumeroTarefa()
        {
            int numeroContato;
            bool numeroContatoEncontrado;

            do
            {
                Console.Write("Digite o número da tarefa que deseja editar: ");
                numeroContato = Convert.ToInt32(Console.ReadLine());

                numeroContatoEncontrado = repositorioTarefa.RegistroExiste(numeroContato);

                if (numeroContatoEncontrado == false)
                    notificador.ApresentarMensagem("Número da tarefa não encontrada, digite novamente", TipoMensagem.Atencao);

            } while (numeroContatoEncontrado == false);
            return numeroContato;
        }

        private DateTime ObterData(string mensagem)
        {
            while (true)
            {
                DateTime data;
                Console.Write(mensagem);
                string lerTela = Console.ReadLine();

                bool conversaoRealizada = DateTime.TryParse(lerTela, out data);

                if (conversaoRealizada)
                    return data;

                notificador.ApresentarMensagem("Data não informada no formato correto, tente novamente.\n", TipoMensagem.Atencao);
            }
        }

        private List<Item> ObterListaItens()
        {
            List<Item> itens = new List<Item>();
            
            Console.Write("Digite 's' ou informe a quantidade de itens da tarefa: ");
            string lerTela = Console.ReadLine();

            if (lerTela == "s")
                return itens;

            int quantidadeItens = Convert.ToInt32(lerTela);
            for (int i = 0; i < quantidadeItens; i++)
            {
                Item item = new Item();

                item.Id = i+1;
                Console.Write($"Informe a descrição do {i+1}º item: ");
                item.descricao = Console.ReadLine();
                item.Percentual = 0;
                itens.Add(item);
            }

            return itens;
        }

        #endregion
    }
}
