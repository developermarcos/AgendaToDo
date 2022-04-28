using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAplicacao.WinFormsApp
{
    public partial class TelaCrudTarefas : Form
    {
        public TelaCrudTarefas(string titulo)
        {
            InitializeComponent();
            this.Name = titulo;
            this.textBoxNumero.Text = "0";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Tarefa tarefaCadastro = new Tarefa();
            //tarefaCadastro.descricao = this.textBoxDescricao.Text;

            
        }
    }
}
