using Dominio.ToDo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaToDo.WinFor
{
    public partial class TelaCrudTarefas : Form
    {
        Tarefa tarefa;
        public string NomeTela { set { this.Name = value; } }
        public TelaCrudTarefas(string titulo)
        {
            InitializeComponent();
            NomeTela = titulo;
            this.textBoxNumero.Text = "0";
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                textBoxNumero.Text = tarefa.Numero.ToString();
                textBoxDescricao.Text = tarefa.Titulo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = textBoxDescricao.Text;

            
        }
    }
}
