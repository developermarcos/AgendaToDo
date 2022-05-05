using Infra.ToDo.Compartilhado.Serializador;
using Dominio.ToDo.ModuloContato;
using Infra.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.ModuloContato
{
    public class RepositorioContatoArquivoSeparado : RepositorioBaseArquivosDiferentes<Contato>
    {
        public RepositorioContatoArquivoSeparado() : base(new SerializadorEmJsonNewton<Contato>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\contatos.json"))
        {
        }
        public string ValidaCamposIguais(Contato contatoValidar)
        {
            string registroValido = "REGISTRO_VALIDO";
            foreach(var item in registros)
            {
                if (contatoValidar.VerificaCamposIguais(item) == true)
                {
                    registroValido = "Campos NOME, EMAIL e TELEFONE devem ser únicos no sistema";
                    break;
                }
            }
            return registroValido;
        }

        public List<Contato> ObterRegistrosOrdenadoPorCargo()
        {
            List<Contato> contatosOrdenadosPorCargo = registros;

            contatosOrdenadosPorCargo.Sort((x, y) => string.Compare(x.cargo, y.cargo));

            return contatosOrdenadosPorCargo;
        }
    }
}
