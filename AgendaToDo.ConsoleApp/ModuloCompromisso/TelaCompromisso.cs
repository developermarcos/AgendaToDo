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
            Console.WriteLine("Digite 6 para Compromissos passados");
            Console.WriteLine("Digite 6 para Compromissos futuros");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public void EditarRegistro()
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new System.NotImplementedException();
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
                MostrarTitulo("Visualização de Contato");

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

        public void CompromissoSemana()
        {

        }

        public void CompromissoDia()
        {

        }

        public void CompromissosPassados()
        {

        }
        
       public void CompromissosFuturos(TimeSpan inicio, TimeSpan fim)
       {

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

                Console.WriteLine("Formato invalido, tente novamente");
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

        //private void PopularContatos()
        //{
        //    Contato contato1 = new Contato("Marcos", "m@m.com", "(49)99999-0000", "google", "Team leader");
        //    Contato contato2 = new Contato("Joao", "j@m.com", "(49)44444-0000", "google", "Caixa");
        //    Contato contato3 = new Contato("Ana", "a@m.com", "(49)55555-0000", "google", "Gerente");
        //    Contato contato4 = new Contato("Bruna", "b@m.com", "(49)77777-0000", "google", "Caixa");
        //    Contato contato5 = new Contato("Zé", "z@m.com", "(49)11111-0000", "google", "Cozinheiro");

        //    repositorioContato.Inserir(contato1);
        //    repositorioContato.Inserir(contato2);
        //    repositorioContato.Inserir(contato3);
        //    repositorioContato.Inserir(contato4);
        //    repositorioContato.Inserir(contato5);
        //}

        #endregion
    }
}
