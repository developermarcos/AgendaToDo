using Apresentacao.ToDo.ModuloContato;
using Dominio.ToDo.ModuloCompromisso;
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

namespace Apresentacao.ToDo.ModuloCompromisso
{
    public partial class TelaCrudCompromisso : Form
    {
        RepositorioContato _repositorioContato;
        Compromisso compromisso;
        public TelaCrudCompromisso(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            _repositorioContato = repositorioContato;
            Name = "Selecionar contato";
            compromisso = new Compromisso();
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }
            set
            {
                compromisso = value;
                this.textBoxNumero.Text = compromisso.Numero.ToString();
                this.textBoxAssunto.Text = compromisso.assunto;
                this.textBoxLocal.Text = compromisso.local;
                this.textBoxData.Text = compromisso.DataCompromisso;
                this.textBoxHoraInicio.Text = compromisso.HoraInicio;
                this.textBoxHoraFim.Text = compromisso.HoraFim;
                if(compromisso.contato != null)
                    this.textBoxContato.Text = compromisso.contato.nome;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            compromisso.assunto = this.textBoxAssunto.Text;
            compromisso.local = this.textBoxLocal.Text;
            compromisso.dataCompromisso = Convert.ToDateTime(this.textBoxData.Text);
            compromisso.SetHorarios(this.textBoxHoraInicio.Text, this.textBoxHoraFim.Text);
        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e)
        {
            TelaSelecionaContato telaSelecionaContato = new TelaSelecionaContato(_repositorioContato);
            DialogResult resultado = telaSelecionaContato.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                compromisso.contato = telaSelecionaContato.contatoSelecionado;
                this.textBoxContato.Text = compromisso.contato.nome;
            }
        }
    }
}
