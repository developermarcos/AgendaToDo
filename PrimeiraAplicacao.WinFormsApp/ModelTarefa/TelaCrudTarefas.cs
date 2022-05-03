using Apresentacao.ToDo.ModelTarefa;
using Dominio.ToDo.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
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
                AtivaPrioridadeSelecionada();
                ListarItensTarefa();
            }
        }

        private void ListarItensTarefa()
        {
            List<string> titulos = tarefa.Itens.Select(x => x.Titulo).ToList();
            foreach(var item in titulos)
                listaItens.Items.Add(item);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = textBoxDescricao.Text;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.prioridade = retornaRadioButtonChecked();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            List<string> titulos = tarefa.Itens.Select(x => x.Titulo).ToList();

            if (txtBoxItensTarefa.Text != null && txtBoxItensTarefa.Text != "" && titulos.Contains(txtBoxItensTarefa.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa(txtBoxItensTarefa.Text);

                tarefa.Itens.Add(itemTarefa);

                listaItens.Items.Add(itemTarefa);
            }
            else
            {
                MessageBox.Show("Iten ja existe.", "Adicionar item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtBoxItensTarefa.Text = null;
        }
        public void AtivaPrioridadeSelecionada()
        {
            if (tarefa.prioridade == Prioridade.Baixa)
                rBtnBaixa.Checked = true;

            else if (tarefa.prioridade == Prioridade.Media)
                rBtnMedia.Checked = true;

            else if (tarefa.prioridade == Prioridade.Alta)
                rBtnAlta.Checked = true;
        }

        private Prioridade retornaRadioButtonChecked()
        {
            
            if (rBtnBaixa.Checked == true)
                return Prioridade.Baixa;
            else if (rBtnMedia.Checked == true)
                return Prioridade.Media;
            else if(rBtnAlta.Checked == true)
                return Prioridade.Alta;

            return default;
        }
    }
}
