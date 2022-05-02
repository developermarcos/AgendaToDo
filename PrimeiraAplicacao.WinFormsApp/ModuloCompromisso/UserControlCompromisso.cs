using Dominio.ToDo.ModuloCompromisso;
using Infra.ToDo.ModuloCompromisso;
using Infra.ToDo.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.ToDo.ModuloCompromisso
{
    public partial class UserControlCompromisso : UserControl
    {
        RepositorioCompromisso _repositorioCompromisso;
        RepositorioContato _repositorioContato;
        public UserControlCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            InitializeComponent();

            _repositorioCompromisso = repositorioCompromisso;
            _repositorioContato = repositorioContato;
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = _repositorioCompromisso.SelecionarTodos();

            listBoxCompromissos.Items.Clear();
            if (compromissos != null)
                foreach (Compromisso t in compromissos)
                {
                    listBoxCompromissos.Items.Add(t);
                }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCrudCompromisso telaCrudCompromisso = new TelaCrudCompromisso(_repositorioContato);

            DialogResult resultado = telaCrudCompromisso.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                if (!_repositorioCompromisso.VerificarConflitoCompromissos(telaCrudCompromisso.Compromisso))
                {
                    MessageBox.Show("Conflito de horários com outro compromisso", 
                        "Cadastro de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string registroInserido = _repositorioCompromisso.Inserir(telaCrudCompromisso.Compromisso);

                if (registroInserido == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Registro inserido com sucesso!", "Cadastro de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarCompromissos();
                }
                else
                    MessageBox.Show(registroInserido, "Cadastro de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione uma Compromisso primeiro",
                "Edição de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCrudCompromisso telaCrudCompromisso = new TelaCrudCompromisso(_repositorioContato);

            telaCrudCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCrudCompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string registroInserido = _repositorioCompromisso.Editar(telaCrudCompromisso.Compromisso);

                if (registroInserido == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Registro editado com sucesso!", "Edição de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarCompromissos();
                }
                else
                    MessageBox.Show(registroInserido, "Edição de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione uma Compromisso primeiro",
                "Edição de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Contato?",
                "Exclusão de contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }
    }
}
