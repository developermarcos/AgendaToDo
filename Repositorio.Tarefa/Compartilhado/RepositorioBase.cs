using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ToDo.Compartilhado;
using Dominio.ToDo.Compartilhado.Serializador;

namespace Infra.ToDo.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected ISerializador<T> serializador;
        protected List<T> registros;
        protected int contador = 0;
        
        public RepositorioBase(ISerializador<T> serializador)
        {
            this.serializador = serializador;

            registros = serializador.CarregarRegistrosDoArquivo();

            if (registros != null)
                contador = registros.Max(x => x.Numero);
            else
                registros = new List<T>();

        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public void Inserir(T novoRegistro)
        {
            novoRegistro.Numero = ++contador;
            registros.Add(novoRegistro);

            serializador.GravarRegistrosEmArquivo(registros);
        }

        public void Editar(T registro)
        {
            registros.RemoveAll(x => x.Numero == registro.Numero);

            registros.Add(registro);

            serializador.GravarRegistrosEmArquivo(registros);
        }

        public void Excluir(T registro)
        {
            registros.Remove(registro);

            serializador.GravarRegistrosEmArquivo(registros);
        }

    }
}
