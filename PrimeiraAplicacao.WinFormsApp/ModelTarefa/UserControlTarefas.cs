using AgendaToDo.WinFor;
using Dominio.ToDo.TarefaItens;
using Infra.ToDo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.ToDo.ModelTarefa
{
    public partial class UserControlTarefas : UserControl
    {
        RepositorioTarefa _repositorioContato;
        public UserControlTarefas(RepositorioTarefa repositorioTarefa)
        {
            InitializeComponent();
            _repositorioContato=repositorioTarefa;
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = _repositorioContato.SelecionarTodos();

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
                _repositorioContato.Inserir(telaCadastrar.Tarefa);
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
                _repositorioContato.Editar(tela.Tarefa);
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
                _repositorioContato.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }
    }
}
