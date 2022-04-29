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
    }
}
