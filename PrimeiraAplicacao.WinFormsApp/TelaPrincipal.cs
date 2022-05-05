using AgendaToDo.WinFor;
using Apresentacao.ToDo.Compartilhado;
using Apresentacao.ToDo.ModelTarefa;
using Apresentacao.ToDo.ModuloCompromisso;
using Apresentacao.ToDo.ModuloContato;
using Dominio.ToDo;
using Infra.ToDo.ModuloTarefa;
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
using Infra.ToDo.Compartilhado.Serializador;
using Infra.ToDo.Compartilhado;

namespace Apresentacao.ToDo
{
    public partial class TelaPrincipal : Form
    {
        DataContext dataContext;
        //RepositorioTarefaArquivoSeparado _repositorioTarefa;
        //RepositorioContatoArquivoSeparado _repositorioContato;
        //RepositorioCompromissoArquivoSeparado _repositorioCompromisso;

        RepositorioCompromisso _repositorioCompromisso;
        RepositorioContato _repositorioContatoUnico;
        RepositorioTarefa _repositorioTarefa;
        ISerializador serializador;

        public TelaPrincipal()
        {
            InitializeComponent();
            dataContext = new DataContext();
            serializador = new SerializadorJsonNewtonUnicoArquivo();
            //_repositorioTarefa = new RepositorioTarefaArquivoSeparado();
            ////_repositorioContato = new RepositorioContatoArquivoSeparado();
            
            _repositorioContatoUnico = new RepositorioContato(dataContext, serializador);
            _repositorioCompromisso = new RepositorioCompromisso(dataContext, serializador);
            _repositorioTarefa = new RepositorioTarefa(dataContext, serializador);
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

            UserControlContato telaContato = new UserControlContato(_repositorioContatoUnico);
            this.panelPrincipal.Controls.Add(telaContato);
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();
            UserControlCompromisso telaCompromisso = new UserControlCompromisso(_repositorioCompromisso, _repositorioContatoUnico);
            this.panelPrincipal.Controls.Add(telaCompromisso);
        }
    }
}
