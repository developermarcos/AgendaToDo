using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ToDo.Compartilhado;
using Infra.ToDo.Compartilhado.Serializador;

namespace Infra.ToDo.Compartilhado
{
    public abstract class RepositorioBaseArquivosDiferentes<T> where T : EntidadeBase
    {
        protected ISerializadorGenerico<T> serializador;
        protected List<T> registros;
        protected int contador = 0;

        public RepositorioBaseArquivosDiferentes(ISerializadorGenerico<T> serializador)
        {
            this.serializador = serializador;

            registros = serializador.CarregarRegistrosDoArquivo();

            if (registros != null)
                contador = registros.Max(x => x.Numero);
            else
                registros = new List<T>();

        }

        public virtual List<T> SelecionarTodos()
        {
            return registros.ToList();
        }

        public virtual string Inserir(T novoRegistro)
        {
            string dadosValidos = novoRegistro.Validar();

            if(dadosValidos == "REGISTRO_VALIDO")
            {
                novoRegistro.Numero = ++contador;

                registros.Add(novoRegistro);

                serializador.GravarRegistrosEmArquivo(registros);
            }

            return dadosValidos;
        }

        public virtual string Editar(T registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                registros.RemoveAll(x => x.Numero == registro.Numero);

                registros.Add(registro);

                List<T> ordenarRegistros = registros;

                registros = ordenarRegistros.OrderBy(x => x.Numero).ToList();

                serializador.GravarRegistrosEmArquivo(registros);
            }

            return dadosValidos;
        }

        public virtual string Excluir(T registro)
        {
            string dadosValidos = registro.Validar();

            if (dadosValidos == "REGISTRO_VALIDO")
            {
                registros.Remove(registro);

                serializador.GravarRegistrosEmArquivo(registros);
            }

            return dadosValidos;
        }

    }
}
