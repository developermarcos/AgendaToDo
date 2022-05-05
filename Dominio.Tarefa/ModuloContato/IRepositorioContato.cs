using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.ModuloContato
{
    public interface IRepositorioContato
    {
        List<Contato> SelecionarTodos();

        string Inserir(Contato novoRegistro);

        string Editar(Contato registro);

        abstract string Excluir(Contato registro);

        string ValidaCamposIguais(Contato contatoValidar);

        List<Contato> ObterRegistrosOrdenadoPorCargo();
    }
}
