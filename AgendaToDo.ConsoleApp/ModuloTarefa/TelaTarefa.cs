using AgendaToDo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;


namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public enum TipoDado { Cadastro, Edicao}
    public class TelaTarefa : TelaBase, ICadastroBase
    {
        RepositorioTarefa repositorioTarefa;
        public TelaTarefa(Notificador notificador, RepositorioTarefa repositorioTarefa) : base("Tela Tarefa", notificador)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ApresentarMenu()
        {
            string opcaoSelecionada;

            MostrarTitulo(this.titulo);

            Console.WriteLine("Digite 1 para Cadastrar");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Editar itens");
            Console.WriteLine("Digite 6 para Visualizar pendentes");
            Console.WriteLine("Digite 7 para Visualizar finalizadas");
            
            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando nova tarefa");

            bool temTarefaCadastrada = VisualizarRegistros("Pesquisando");

            if (!temTarefaCadastrada)
            {
                _notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar", TipoMensagem.Atencao);
                return;
            }

            int idTarefa = ObterNumeroTarefa();

            Tarefa novaTarefa = ObterTarefa(TipoDado.Edicao);

            string mensagemValidacao = repositorioTarefa.Editar(idTarefa, novaTarefa);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                _notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

            else
                _notificador.ApresentarMensagem("Tarefa não inserida, erro na validação dos campos", TipoMensagem.Erro);
        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo nova tarefa");

            bool temTarefaCadastrada = VisualizarTarefasConcluidas("Pesquisando");

            if (!temTarefaCadastrada)
            {
                _notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar", TipoMensagem.Atencao);
                return;
            }

            int idTarefa = ObterNumeroTarefa();

            repositorioTarefa.Excluir(idTarefa);

            _notificador.ApresentarMensagem("Tarefa excluída com sucesso!", TipoMensagem.Sucesso);
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo nova tarefa");

            Tarefa novaTarefa = ObterTarefa(TipoDado.Cadastro);

            string mensagemValidacao = repositorioTarefa.Inserir(novaTarefa);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                _notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

            else
                _notificador.ApresentarMensagem("Tarefa não inserida, erro na validação dos campos", TipoMensagem.Erro);
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

        public void EditarItensTarefa()
        {
            MostrarTitulo("Editando itens da tarefa");

            bool temTarefaCadastrada = VisualizarTarefasPendentes("Pesquisando");

            if (!temTarefaCadastrada)
            {
                _notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar", TipoMensagem.Atencao);
                return;
            }

            int idTarefa = ObterNumeroTarefa();

            Tarefa tarefaAtualizada = ObterNovasPorcentagens(idTarefa);

            string mensagemValidacao = repositorioTarefa.Editar(idTarefa, tarefaAtualizada);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                _notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

            else
                _notificador.ApresentarMensagem("Tarefa não inserida, erro na validação dos campos", TipoMensagem.Erro);
        }

        public bool VisualizarTarefasPendentes(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de Tarefa pendentes");

            List<Tarefa> tarefas = repositorioTarefa.ObterTarefasPendentes();

            if (tarefas.Count == 0)
                return false;

            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(tarefa.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public bool VisualizarTarefasConcluidas(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de Tarefa concluídas");

            List<Tarefa> tarefas = repositorioTarefa.ObterTarefasConcluidas();

            if (tarefas.Count == 0)
                return false;

            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(tarefa.ToString());

                Console.WriteLine();
            }

            return true;
        }


        public void PopularTarefas()
        {
            Item item1 = new Item("Cadastro tela", 5);
            Item item2 = new Item("Repositorio", 10);
            
            DateTime inicio = new DateTime(2022,04,20);
            DateTime fim = new DateTime(2022, 04, 25);

            List<Item> itens = new List<Item>();
            itens.Add(item1);
            itens.Add(item2);

            Tarefa tarefa1 = new Tarefa(Prioridade.Media, "Cadastro compromisso", inicio, fim, itens);
            Tarefa tarefa2 = new Tarefa(Prioridade.Alta, "Cadastro tarefa", inicio, fim, itens);
            Tarefa tarefa3 = new Tarefa(Prioridade.Baixa, "Cadastro contato", inicio, fim, itens);

            repositorioTarefa.Inserir(tarefa1);
            repositorioTarefa.Inserir(tarefa2);
            repositorioTarefa.Inserir(tarefa3);
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
                    _notificador.ApresentarMensagem("Número da tarefa não encontrada, digite novamente", TipoMensagem.Atencao);

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

                _notificador.ApresentarMensagem("Data não informada no formato correto, tente novamente.\n", TipoMensagem.Atencao);
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

                Console.Write($"Informe a descrição do {i+1}º item: ");
                item.descricao = Console.ReadLine();
                item.Percentual = 0;
                itens.Add(item);
            }

            return itens;
        }

        private Tarefa ObterNovasPorcentagens(int idTarefa)
        {

            Tarefa tarefa = repositorioTarefa.ObterRegistro(idTarefa);

            foreach (Item item in tarefa.itens)
            {
                Console.WriteLine(item.ToString());
            }

            List<Item> itensAtualizados = new List<Item>();

            for (int i = 0; i < tarefa.itens.Count; i++)
            {
                decimal percentual; 
                Item item = new Item();
                while (true)
                {
                    Console.Write("\nInforme a porcentagem de "+ tarefa.itens[i].descricao + ": ");
                    string lerTela = Console.ReadLine();
                    bool conversaoRealizada = Decimal.TryParse(lerTela, out percentual);
                    if (conversaoRealizada)
                    {
                        item.Percentual = Convert.ToDecimal(lerTela);
                        break;
                    }

                    _notificador.ApresentarMensagem("Porcentagem invalida, tente novamente", TipoMensagem.Erro);
                }
                item.descricao = tarefa.itens[i].descricao;
                
                itensAtualizados.Add(item);
            }

            tarefa.itens = itensAtualizados;

            return tarefa;
        }

        #endregion
    }
}
