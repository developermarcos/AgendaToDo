using Dominio.ToDo.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        List<Compromisso> SelecionarTodos();

        string Inserir(Compromisso novoRegistro);

        string Editar(Compromisso registro);

        abstract string Excluir(Compromisso registro);

        public bool VerificarConflitoCompromissos(Compromisso compromisso);
        public List<Compromisso> SelecionarCompromissosPassados();

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime inicio, DateTime fim);

        public bool ContatoTemCompromisso(Contato contatoInformado);
    }
}
