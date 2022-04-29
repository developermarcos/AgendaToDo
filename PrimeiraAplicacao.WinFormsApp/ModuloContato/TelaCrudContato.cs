using Dominio.ToDo.ModuloContato;
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
    public partial class TelaCrudContato : Form
    {
        public Contato contato;
        public string NomeTela { set { this.Name = value; } }
        public TelaCrudContato(string titulo)
        {
            InitializeComponent();
            NomeTela = titulo;
            this.textBoxNumero.Text = "0";
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                this.textBoxNumero.Text = contato.Numero.ToString();
                this.textBoxNome.Text = contato.nome;
                this.textBoxEmpresa.Text = contato.empresa;
                this.textBoxEmail.Text = contato.email;
                this.textBoxTelefone.Text = contato.telefone;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            contato.nome = this.textBoxNome.Text;
            contato.telefone = this.textBoxTelefone.Text;
            contato.empresa = this.textBoxEmpresa.Text;
            contato.email = this.textBoxEmail.Text;
        }
    }
}
