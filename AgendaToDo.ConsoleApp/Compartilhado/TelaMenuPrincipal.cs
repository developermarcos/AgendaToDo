using AgendaToDo.ConsoleApp.ModuloCompromisso;
using AgendaToDo.ConsoleApp.ModuloContato;
using AgendaToDo.ConsoleApp.ModuloTarefa;
using System;

namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private Notificador Notificador;
        private string opcaoSelecionada;

        #region Declaração repositórios

        //COMPROMISSO
        private TelaCompromisso telaCompromisso;
        private RepositorioCompromisso repositorioCompromisso;

        //CONTATO
        private TelaContato telaContato;
        private RepositorioContato repositorioContato;

        //TAREFA
        private TelaTarefa telaTarefa;
        private RepositorioTarefa repositorioTarefa;

        #endregion


        public TelaMenuPrincipal(Notificador notificador)
        {
            this.Notificador = notificador;

            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            repositorioTarefa = new RepositorioTarefa();


            telaContato = new TelaContato(notificador, repositorioContato);
            telaCompromisso = new TelaCompromisso(notificador, repositorioCompromisso, repositorioContato, telaContato);
            telaTarefa = new TelaTarefa(notificador, repositorioTarefa);

            telaContato.PopularContatos();
            telaCompromisso.PopularCompromissos();
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Clube da Leitura 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Cadastrar Contato");
            Console.WriteLine("Digite 2 para Cadastrar Compromisso");
            Console.WriteLine("Digite 3 para Cadastrar Tarefa");
            
            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaContato;

            else if (opcao == "2")
                tela = telaCompromisso;

            else if (opcao == "3")
                tela = telaTarefa;


            return tela;
        }
    }
}
