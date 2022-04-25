using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.Compartilhado
{
    public abstract class TelaBase
    {
        public string titulo;
        protected Notificador _notificador;

        public TelaBase(string tutilo, Notificador notificador)
        {
            this.titulo = tutilo;
            this._notificador = notificador;
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

        protected virtual TValor ObterValor<TValor>(string mensagem)
        {
            TValor valor;
            Type tipoVariavel = typeof(TValor);
            while (true)
            {
                try
                {
                    Console.Write(mensagem);
                    valor = (TValor)Convert.ChangeType(Console.ReadLine(), tipoVariavel);
                    break;
                }
                catch(FormatException)
                {
                    string errorMsg = "";
                    switch (tipoVariavel.Name.ToUpper())
                    {
                        case "DATETIME": errorMsg = "Formato de data invalido, tente novamente."; break;
                        case "INT32": errorMsg = "Formato de data invalido, tente novamente."; break;
                        case "DECIMAL": errorMsg = "Formato de data invalido, tente novamente."; break;
                    }
                    _notificador.ApresentarMensagem(errorMsg, TipoMensagem.Erro);
                }
            }
            return valor;
        }
    }
}
