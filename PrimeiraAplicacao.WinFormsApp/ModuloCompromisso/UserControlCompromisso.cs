using Dominio.ToDo.ModuloCompromisso;
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

namespace Apresentacao.ToDo.ModuloCompromisso
{
    public partial class UserControlCompromisso : UserControl
    {
        RepositorioCompromisso _repositorioCompromisso;
        RepositorioContato _repositorioContato;
        public UserControlCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            InitializeComponent();

            _repositorioCompromisso = repositorioCompromisso;
            _repositorioContato = repositorioContato;
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = _repositorioCompromisso.SelecionarTodos();

            listBoxCompromissos.Items.Clear();
            if (compromissos != null)
                foreach (Compromisso t in compromissos)
                {
                    listBoxCompromissos.Items.Add(t);
                }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCrudCompromisso telaCrudCompromisso = new TelaCrudCompromisso(_repositorioContato);

            DialogResult resultado = telaCrudCompromisso.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                string registroInserido = _repositorioCompromisso.Inserir(telaCrudCompromisso.Compromisso);

                if (registroInserido == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Registro inserido com sucesso!", "Cadastro de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarCompromissos();
                }
                else
                    MessageBox.Show(registroInserido, "Cadastro de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
