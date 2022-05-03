using AgendaToDo.WinFor;
using Dominio.ToDo.ModuloTarefa;
using Infra.ToDo.ModuloTarefa;
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
        RepositorioTarefa _repositorioTarefa;
        public UserControlTarefas(RepositorioTarefa repositorioTarefa)
        {
            InitializeComponent();
            _repositorioTarefa=repositorioTarefa;
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

            DialogResult resultado = telaCadastrar.ShowDialog(this);

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

        private void btnAtualizarItem_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAtualizarItem telaAtualizarItem = new TelaAtualizarItem(tarefaSelecionada.Titulo);

            telaAtualizarItem.ItensTarefa = tarefaSelecionada.Itens;

            DialogResult resultado = telaAtualizarItem.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.AtualizarItens(tarefaSelecionada, telaAtualizarItem.ItensConcluidos, telaAtualizarItem.ItensPendentes);
                CarregarTarefas();
            }
        }

        private void tabControlTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlTarefas.SelectedIndex == 0)
            {
                CarregarTarefas();
            }
            else if(tabControlTarefas.SelectedIndex == 1)
            {
                CarregarTarefasPendentes();
            }
            else if(tabControlTarefas.SelectedIndex == 2)
            {
                CarregarTarefasConcluidas();
            }

        }

        private void CarregarTarefasConcluidas()
        {
            List<Tarefa> tarefas = _repositorioTarefa.SelecionaTarefasConcluidas();

            listaConcluidas.Items.Clear();
            if (tarefas != null)
                foreach (Tarefa t in tarefas)
                {
                    listaConcluidas.Items.Add(t);
                }
        }

        private void CarregarTarefasPendentes()
        {
            List<Tarefa> tarefas = _repositorioTarefa.SelecionaTarefasPendentes();

            listaPendentes.Items.Clear();
            if (tarefas != null)
                foreach (Tarefa t in tarefas)
                {
                    listaPendentes.Items.Add(t);
                }
        }
    }
}
