using AgendaToDo.ConsoleApp.Compartilhado;
using System.Collections.Generic;

namespace AgendaToDo.ConsoleApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {

        public List<Contato> ObterRegistrosOrdenadoPorCargo()
        {
            List<Contato> contatosOrdenadosPorCargo = registros;

            contatosOrdenadosPorCargo.Sort((x, y) => string.Compare(x.cargo, y.cargo));

            return contatosOrdenadosPorCargo;
        }
    }
}
