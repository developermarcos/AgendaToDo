using Dominio.ToDo.ModuloTarefa;
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
    public partial class TelaAtualizarItem : Form
    {
        List<ItemTarefa> itensTarefa;
        public TelaAtualizarItem(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }
        public List<ItemTarefa> ItensTarefa
        {
            get { return itensTarefa; }
            set 
            { 
                itensTarefa = value;
                PopularListaTarefas();
            }
        }

        private void PopularListaTarefas()
        {
            listaItensPendentes.Items.Clear();
            listaItensConcluidos.Items.Clear();
            
            if (itensTarefa != null)
                foreach (ItemTarefa t in itensTarefa)
                {
                    if(t.Concluido == false)
                        listaItensPendentes.Items.Add(t);
                    else
                        listaItensConcluidos.Items.Add(t);
                }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void listaItens_DoubleClick(object sender, EventArgs e)
        {
            ItemTarefa itemSelecionado = (ItemTarefa)listaItensPendentes.SelectedItem;
            textBoxTarefaSelecionada.Text = itemSelecionado.Titulo;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string itemSelecionado = textBoxTarefaSelecionada.Text;
            bool status = RetornaStatusItem();
            AtualizaItens(itemSelecionado, status);
            LimparCampos();
            PopularListaTarefas();
        }

        private void AtualizaItens(string itemSelecionado, bool status)
        {
            if (status == true)
            {
                for (int i = 0; i < itensTarefa.Count; i++)
                {
                    if (itensTarefa[i].Titulo == itemSelecionado)
                    {
                        itensTarefa[i].Concluir();
                    }
                }
            }
            else
            {
                for (int i = 0; i < itensTarefa.Count; i++)
                {
                    if (itensTarefa[i].Titulo == itemSelecionado)
                    {
                        itensTarefa[i].MarcarPendente();
                    }
                }
            }
        }

        private bool RetornaStatusItem()
        {
            if (rBtnConcluido.Checked == true)
                return true;
            else
                return false;
        }
        private void LimparCampos()
        {
            rBtnConcluido.Checked = false;
            rBtnPendente.Checked = false;
            textBoxTarefaSelecionada.Text = null;
        }

        private void listaItensConcluidos_DoubleClick(object sender, EventArgs e)
        {
            ItemTarefa itemSelecionado = (ItemTarefa)listaItensConcluidos.SelectedItem;
            textBoxTarefaSelecionada.Text = itemSelecionado.Titulo;
        }

        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                List<ItemTarefa> itensPendentes = new List<ItemTarefa>();
                itensPendentes = itensTarefa.FindAll(x => x.Concluido == false).ToList();
                return itensPendentes;
            }
        }
        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                List<ItemTarefa> itensConcluidos = new List<ItemTarefa>();
                itensConcluidos = itensTarefa.FindAll(x => x.Concluido == true).ToList();
                return itensConcluidos;
            }
        }
    }
}
