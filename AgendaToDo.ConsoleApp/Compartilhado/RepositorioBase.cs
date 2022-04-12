using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        public int numero;
        public List<T> registros;

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T item)
        {
            item.numero = ++numero;
            item.ativo = true;
            string mensagemValidacao = item.Validar();

            if (mensagemValidacao == "REGISTRO_VALIDO")
                registros.Add(item);
            else
                --numero;
            
            return mensagemValidacao;
        }

        public virtual void Editar(int numeroEdicao, T item)
        {
            T registro = registros.Find(x => x.numero == numeroEdicao);

            registros.Remove(registro);

            item.numero = numeroEdicao;

            registros.Add(item);
        }

        public virtual bool Excluir(int numeroExclusao)
        {
            registros.RemoveAll(x => x.numero == numeroExclusao);
            return true;
        }

        public List<T> ObterTodosRegistros()
        {
            return registros;
        }

        public T ObterRegistro(int numeroRegistro)
        {
            return registros.Find(x => x.numero == numeroRegistro);
        }

        public bool RegistroExiste(int numeroRegistro)
        {
            return registros.Exists(x => x.numero == numeroRegistro);
        }
    }
}
