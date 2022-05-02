using Dominio.ToDo.ModuloContato;
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

namespace Apresentacao.ToDo.ModuloContato
{
    public partial class UserControlContato : UserControl
    {
        RepositorioContato _repositorioContato;
        public UserControlContato(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            _repositorioContato=repositorioContato;
            Carregarcontatos();
        }

        private void Carregarcontatos()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();

            listBoxContatos.Items.Clear();
            if (contatos != null)
                foreach (Contato t in contatos)
                {
                    listBoxContatos.Items.Add(t);
                }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCrudContato telaContato = new TelaCrudContato("Cadastrar");
            telaContato.contato = new Contato();

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string validaCamposUnicos = _repositorioContato.ValidaCamposIguais(telaContato.Contato);

                if(validaCamposUnicos != "REGISTRO_VALIDO")
                {
                    MessageBox.Show(validaCamposUnicos, "Cadastro de contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string registroInserido = _repositorioContato.Inserir(telaContato.Contato);
                if(registroInserido == "REGISTRO_VALIDO") 
                {
                    MessageBox.Show("Registro inserido com sucesso!", "Cadastro de contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Carregarcontatos();
                }
                else 
                    MessageBox.Show(registroInserido, "Cadastro de contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoselecionada = (Contato)listBoxContatos.SelectedItem;

            if (contatoselecionada == null)
            {
                MessageBox.Show("Selecione uma Contato primeiro",
                "Edição de contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCrudContato telaContato = new TelaCrudContato("Editar");

            telaContato.Contato = contatoselecionada;

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioContato.Editar(telaContato.Contato);
                Carregarcontatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoselecionada = (Contato)listBoxContatos.SelectedItem;

            if (contatoselecionada == null)
            {
                MessageBox.Show("Selecione uma Contato primeiro",
                "Exclusão de contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Contato?",
                "Exclusão de contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioContato.Excluir(contatoselecionada);
                Carregarcontatos();
            }
        }

        private void btnAgruparCargo_Click(object sender, EventArgs e)
        {
            
            List<Contato> contatos = _repositorioContato.ObterRegistrosOrdenadoPorCargo();

            listBoxContatos.Items.Clear();
            if (contatos != null)
                foreach (Contato t in contatos)
                {
                    listBoxContatos.Items.Add(t);
                }
            
        }
    }
}
