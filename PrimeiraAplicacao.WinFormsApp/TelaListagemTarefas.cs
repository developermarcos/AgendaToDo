using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo;
using Infra.ToDo;

namespace PrimeiraAplicacao.WinFormsApp
{
    public partial class TelaListagemTarefas : Form
    {
        private RepositorioTarefa repositorioTarefa;

        public TelaListagemTarefas()
        {
            SerializadorEmBits<Tarefa> serializador = new SerializadorEmBits<Tarefa>();

            repositorioTarefa = new RepositorioTarefa(serializador);

            
            InitializeComponent();

            CarregarTarefas();
        }
        

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listBoxTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                listBoxTarefas.Items.Add(t);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCrudTarefas telaCadastrar = new TelaCrudTarefas("Cadastrar");
            telaCadastrar.ShowDialog();
        }
    }
}
