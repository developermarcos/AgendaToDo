using AgendaToDo.WinFor;
using Apresentacao.ToDo.Compartilhado;
using Apresentacao.ToDo.ModelTarefa;
using Apresentacao.ToDo.ModuloCompromisso;
using Apresentacao.ToDo.ModuloContato;
using Dominio.ToDo;
using Infra.ToDo;
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

namespace Apresentacao.ToDo
{
    public partial class TelaPrincipal : Form
    {
        RepositorioTarefa _repositorioTarefa;
        RepositorioContato _repositorioContato;
        RepositorioCompromisso _repositorioCompromisso;


        public TelaPrincipal()
        {
            InitializeComponent();
            _repositorioTarefa = new RepositorioTarefa();
            _repositorioContato = new RepositorioContato();
            _repositorioCompromisso = new RepositorioCompromisso();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();
            UserControlTarefas telaTarefa = new UserControlTarefas(_repositorioTarefa);
            this.panelPrincipal.Controls.Add(telaTarefa);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            UserControlContato telaContato = new UserControlContato(_repositorioContato);
            this.panelPrincipal.Controls.Add(telaContato);
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();
            UserControlCompromisso telaCompromisso = new UserControlCompromisso(_repositorioCompromisso, _repositorioContato);
            this.panelPrincipal.Controls.Add(telaCompromisso);
        }
    }
}
