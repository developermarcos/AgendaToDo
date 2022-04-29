using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Dominio.ToDo.Compartilhado.Serializador;
using Dominio.ToDo;
using Infra.ToDo;

namespace AgendaToDo.WinFor
{
    public partial class TelaListagemTarefas : Form
    {
        private RepositorioTarefa _repositorioTarefa;

        public TelaListagemTarefas(string mensagem)
        {
            _repositorioTarefa = new RepositorioTarefa();

            this.Name = mensagem;
            
            InitializeComponent();

            CarregarTarefas();
        }
        

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = _repositorioTarefa.SelecionarTodos();

            listBoxTarefas.Items.Clear();
            if (tarefas != null)
                foreach (Tarefa t in tarefas)
                {
                    listBoxTarefas.Items.Add(t);
                }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCrudTarefas telaCadastrar = new TelaCrudTarefas("Cadastrar");
            telaCadastrar.Tarefa = new Tarefa();

            DialogResult resultado = telaCadastrar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Inserir(telaCadastrar.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCrudTarefas tela = new TelaCrudTarefas("Editar Tarefa");

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }
    }
}
