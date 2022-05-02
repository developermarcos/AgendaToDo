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
    public partial class TelaSelecionaContato : Form
    {
        RepositorioContato _repositorioContato;
        public Contato contatoSelecionado;
        public TelaSelecionaContato(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            _repositorioContato = repositorioContato;
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
            else
                listBoxContatos.Items.Add("Nenhum item cadastrado");
        }

        private void btnSelecioanr_Click(object sender, EventArgs e)
        {
            if(listBoxContatos.SelectedItem != null && listBoxContatos.SelectedItem != "Nenhum item cadastrado")
                contatoSelecionado = (Contato)listBoxContatos.SelectedItem;
        }
    }
}
