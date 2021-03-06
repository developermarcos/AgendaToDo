using AgendaToDo.ConsoleApp.Compartilhado;
using AgendaToDo.ConsoleApp.ModuloCompromisso;
using AgendaToDo.ConsoleApp.ModuloContato;
using AgendaToDo.ConsoleApp.ModuloTarefa;
using System;

namespace AgendaToDo.ConsoleApp
{
    public class Program
    {
        static Notificador notificador = new Notificador();
        static TelaMenuPrincipal telaMenuPrincipal = new TelaMenuPrincipal(notificador);
        static void Main(string[] args)
        {
            while(true)
            {
                TelaBase telaSelecionada = telaMenuPrincipal.ObterTela();

                string opcaoSelecionada = telaSelecionada.ApresentarMenu();

                if (telaSelecionada is ICadastroBase)
                    GerenciarCadastroBasico(telaSelecionada, opcaoSelecionada);
                
            }
        }

        private static void GerenciarCadastroBasico(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            ICadastroBase TelaBasico = (ICadastroBase)telaSelecionada;

            if (opcaoSelecionada == "1")
                TelaBasico.InserirRegistro();

            else if (opcaoSelecionada == "2")
                TelaBasico.EditarRegistro();

            else if (opcaoSelecionada == "3")
                TelaBasico.ExcluirRegistro();

            else if (opcaoSelecionada == "4")
            {
                bool temRegistros = TelaBasico.VisualizarRegistros("Tela");

                if (!temRegistros)
                    notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                Console.ReadKey();
            }
            else if (telaSelecionada is TelaContato)//Contato
            {
                TelaContato telaContato = (TelaContato)telaSelecionada;
                if (opcaoSelecionada == "5")
                {
                    bool temRegistros = telaContato.VisualizarRegistrosOrdenador("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
            }//Contato
            else if (telaSelecionada is TelaCompromisso)//Compromisso
            {
                TelaCompromisso telaCompromisso = (TelaCompromisso)telaSelecionada;
                if (opcaoSelecionada == "5")
                {
                    bool temRegistros = telaCompromisso.CompromissoDia("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
                else if (opcaoSelecionada == "6")
                {
                    bool temRegistros = telaCompromisso.CompromissoSemana("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
                else if (opcaoSelecionada == "7")
                {
                    bool temRegistros = telaCompromisso.CompromissosPassados("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
                else if (opcaoSelecionada == "8")
                {
                    bool temRegistros = telaCompromisso.CompromissosFuturos("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
            }//Compromisso
            else if (telaSelecionada is TelaTarefa)//Tarefa
            {
                TelaTarefa telaTarefa = (TelaTarefa)telaSelecionada;
                if (opcaoSelecionada == "5")
                {
                    telaTarefa.EditarItensTarefa();
                }
                else if (opcaoSelecionada == "6")
                {
                    bool temRegistros = telaTarefa.VisualizarTarefasPendentes("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
                else if (opcaoSelecionada == "7")
                {
                    bool temRegistros = telaTarefa.VisualizarTarefasConcluidas("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
            }//Tarefa
        }
    }
}
