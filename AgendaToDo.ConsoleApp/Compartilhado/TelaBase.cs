using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public abstract class TelaBase
    {
        public string titulo;

        public TelaBase(string tutilo)
        {
            this.titulo = tutilo;
        }
        public virtual string ApresentarMenu()
        {
            string opcaoSelecionada;

            MostrarTitulo(this.titulo);

            Console.WriteLine("Digite 1 para Cadastrar");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        protected void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }
    }
}
