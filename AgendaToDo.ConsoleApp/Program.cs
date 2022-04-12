using AgendaToDo.ConsoleApp.Compartilhado;
using AgendaToDo.ConsoleApp.ModuloContato;
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
            else if (telaSelecionada is TelaContato)//VizualizarOrdenadoCargo
            {
                TelaContato telaContato = (TelaContato)telaSelecionada;
                if (opcaoSelecionada == "5")
                {
                    bool temRegistros = telaContato.VisualizarRegistrosOrdenador("Tela");

                    if (!temRegistros)
                        notificador.ApresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);

                    Console.ReadKey();
                }
            }
        }
    }
}
