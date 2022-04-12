using AgendaToDo.ConsoleApp.Compartilhado;
using AgendaToDo.ConsoleApp.ModuloContato;
using System;
using System.Collections.Generic;

namespace AgendaToDo.ConsoleApp.ModuloCompromisso
{
    public class TelaCompromisso : TelaBase, ICadastroBase
    {
        Notificador notificador;
        RepositorioCompromisso repositorioCompromisso;

        RepositorioContato repositorioContato;
        TelaContato telaContato;

        public TelaCompromisso(Notificador notificador, RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato,TelaContato telaContato) : base("Tela Compromisso")
        { 
            this.notificador = notificador;
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
            this.telaContato = telaContato;
        }

        public override string ApresentarMenu()
        {
            string opcaoSelecionada;

            MostrarTitulo(this.titulo);

            Console.WriteLine("Digite 1 para Cadastrar");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Compromissos do dia");
            Console.WriteLine("Digite 6 para Compromissos da semana");
            Console.WriteLine("Digite 7 para Compromissos passados");
            Console.WriteLine("Digite 8 para Compromissos futuros");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando compromisso");
            if (!VisualizarRegistros("Tela"))
            {
                notificador.ApresentarMensagem("Nenhum compromisso cadastrado", TipoMensagem.Atencao);
                return;
            }

            int idCompromisso = ObterNumeroCompromisso();

            if (!telaContato.VisualizarRegistros("Tela"))
            {
                notificador.ApresentarMensagem("Nenhum compromisso cadastrado", TipoMensagem.Atencao);
                return;
            }

            Contato contato = ObterContato();
            Compromisso novoCompromisso = ObterCompromisso(contato);

            string mensagemValidacao = repositorioCompromisso.Editar(idCompromisso, novoCompromisso);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Compromisso inserido com sucesso!", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem("Compromisso não inserido, erro na validação dos campos", TipoMensagem.Erro);
        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo compromisso");
            if (!telaContato.VisualizarRegistros("Tela"))
            {
                notificador.ApresentarMensagem("Nenhum compromisso cadastrado", TipoMensagem.Atencao);
                return;
            }

            int idCompromisso = ObterNumeroCompromisso();

            repositorioCompromisso.Excluir(idCompromisso);

            notificador.ApresentarMensagem("Compromisso excluído com sucesso!", TipoMensagem.Sucesso);

        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo novo compromisso");
            if (!telaContato.VisualizarRegistros(""))
            {
                notificador.ApresentarMensagem("Nenhum contato cadastrado", TipoMensagem.Atencao);
                return;
            }
            Contato contato = ObterContato();
            Compromisso novoCompromisso = ObterCompromisso(contato);

            string mensagemValidacao = repositorioCompromisso.Inserir(novoCompromisso);

            if (mensagemValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Contato inserido com sucesso!", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem("Contato não inserido, erro na validação dos campos", TipoMensagem.Erro);
        }

        public bool VisualizarRegistros(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de compromisso");

            List<Compromisso> compromissos = repositorioCompromisso.ObterTodosRegistros();

            if (compromissos.Count == 0)
                return false;

            foreach (Compromisso compromisso in compromissos)
            {
                Console.WriteLine(compromisso.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public bool CompromissoSemana(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de compromisso da semana");

            DateTime dataFiltro = ObterData("Informe a data de inicio do filtro: ");

            List<Compromisso> compromissos = repositorioCompromisso.CompromissoSemana(dataFiltro);

            if (compromissos.Count == 0)
                return false;

            foreach (Compromisso compromisso in compromissos)
            {
                Console.WriteLine(compromisso.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public bool CompromissoDia(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de compromisso da semana");

            DateTime dataFiltro = ObterData("Informe a data do filtro EX(00/00/0000): ");

            List<Compromisso> compromissos = repositorioCompromisso.CompromissoDia(dataFiltro);

            if (compromissos.Count == 0)
                return false;

            foreach (Compromisso compromisso in compromissos)
            {
                Console.WriteLine(compromisso.ToString());

                Console.WriteLine();
            }

            return true;
        }

        public bool CompromissosPassados(string tipoVisualizado)
        {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de compromisso da semana");

            List<Compromisso> compromissos = repositorioCompromisso.CompromissosPassados();

            if (compromissos.Count == 0)
                return false;

            foreach (Compromisso compromisso in compromissos)
            {
                Console.WriteLine(compromisso.ToString());

                Console.WriteLine();
            }

            return true;
        }
        
        public bool CompromissosFuturos(string tipoVisualizado)
       {
            if (tipoVisualizado == "Tela")
                MostrarTitulo("Visualização de compromisso da semana");

            DateTime inicioFiltro = ObterData("Informe a data de inicio do filtro EX(00/00/0000): ");
            DateTime inicioFinal = ObterData("Informe a data de final do filtro EX(00/00/0000): ");

            List<Compromisso> compromissos = repositorioCompromisso.CompromissosFuturos(inicioFiltro, inicioFinal);

            if (compromissos.Count == 0)
                return false;

            Console.WriteLine("");

            foreach (Compromisso compromisso in compromissos)
            {
                Console.WriteLine(compromisso.ToString());

                Console.WriteLine();
            }

            return true;
        }

        private Contato ObterContato()
        {
            while (true)
            {
                Console.Write("Informe o id do contato que deseja anexar ao compromisso: ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (repositorioContato.RegistroExiste(id))
                    return repositorioContato.ObterRegistro(id);
                else
                    notificador.ApresentarMensagem("Contato informado não encontrado, tente novamente!.\n", TipoMensagem.Atencao);
            }
        }

        public void PopularCompromissos()
        {
            Compromisso compromisso1 = new Compromisso("Compra maquinas", "Orion", new DateTime(2022, 04, 20), new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00), repositorioContato.ObterRegistro(1));
            Compromisso compromisso2 = new Compromisso("Integrador", "Uniplac", new DateTime(2022, 04, 30), new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00), repositorioContato.ObterRegistro(2));
            Compromisso compromisso3 = new Compromisso("Negócio", "Duck Bill", new DateTime(2022, 05, 30), new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00), repositorioContato.ObterRegistro(3));
            Compromisso compromisso4 = new Compromisso("Futebol", "AVEP", new DateTime(2022, 04, 18), new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00), repositorioContato.ObterRegistro(4));
            Compromisso compromisso5 = new Compromisso("Churrasco", "Casa do Rech", new DateTime(2022, 04, 10), new TimeSpan(13, 00, 00), new TimeSpan(18, 00, 00), repositorioContato.ObterRegistro(5));

            repositorioCompromisso.Inserir(compromisso1);
            repositorioCompromisso.Inserir(compromisso2);
            repositorioCompromisso.Inserir(compromisso3);
            repositorioCompromisso.Inserir(compromisso4);
            repositorioCompromisso.Inserir(compromisso5);
        }

        #region métodos privados

        private Compromisso ObterCompromisso(Contato contato)
        {
            Console.Write("Digite o assunto: ");
            string assunto = Console.ReadLine();

            Console.Write("\nDigite o local : ");
            string local = Console.ReadLine();

            DateTime dataCompromisso;
            while (true)
            {
                Console.Write("\nDigite a data: ");
                string data = Console.ReadLine();

                bool conversaoRealizada = DateTime.TryParse(data, out dataCompromisso);

                if (conversaoRealizada)
                    break;

                Console.WriteLine("Formato invalido, tente novamente");
            }

            TimeSpan horaInicio;
            while (true)
            {
                Console.Write("Digite a hora de inicio (Ex: 00:00): ");
                string hora = Console.ReadLine();

                bool conversaoRealizada = TimeSpan.TryParse(hora, out horaInicio);

                if (conversaoRealizada)
                    break;

                Console.WriteLine("Formato invalido, tente novamente");
            }


            TimeSpan horaFim;
            while (true)
            {
                Console.Write("Digite a hora de término: (Ex: 00:00): ");
                string hora = Console.ReadLine();

                bool conversaoRealizada = TimeSpan.TryParse(hora, out horaFim);

                if (conversaoRealizada && horaInicio < horaFim)
                    break;

                Console.WriteLine("Formato invalido ou término inferior a hora de inicio, tente novamente");
            }
            Compromisso compromisso = new Compromisso(assunto, local, dataCompromisso, horaInicio, horaFim, contato);

            return compromisso;
        }

        private int ObterNumeroCompromisso()
        {
            int numeroContato;
            bool numeroContatoEncontrado;

            do
            {
                Console.Write("Digite o número do compromisso que deseja editar: ");
                numeroContato = Convert.ToInt32(Console.ReadLine());

                numeroContatoEncontrado = repositorioCompromisso.RegistroExiste(numeroContato);

                if (numeroContatoEncontrado == false)
                    notificador.ApresentarMensagem("Número do compromisso não encontrado, digite novamente", TipoMensagem.Atencao);

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

        #endregion
    }
}
