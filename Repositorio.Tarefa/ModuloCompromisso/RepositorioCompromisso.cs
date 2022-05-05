using Infra.ToDo.Compartilhado.Serializador;
using Dominio.ToDo.ModuloCompromisso;
using Dominio.ToDo.ModuloContato;
using Infra.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ToDo.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso() : base(new SerializadorEmJsonNewton<Compromisso>(@"C:\Users\marco\source\repos\AgendaToDo\Repositorio.Tarefa\Data\compromissos.json"))
        {
        }
        public bool VerificarConflitoCompromissos(Compromisso compromisso)
        {
            foreach (var item in registros)
            {
                if (compromisso.VerificaDiasIgual(item.dataCompromisso) == true && compromisso.VerificaHorasEmComplito(item))
                    return true;
            }
            return false;
        }
        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (var item in registros)
            {
                if (item.CompromissoPassado())
                    compromissosPassados.Add(item);
            }

            return compromissosPassados;
        }
        public List<Compromisso> SelecionarCompromissosFuturos(DateTime inicio, DateTime fim)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach(var item in registros)
            {
                if (item.CompromissoFuturo(inicio, fim))
                    compromissosFuturos.Add(item);
            }

            return compromissosFuturos;
        }

        public bool ContatoTemCompromisso(Contato contatoInformado)
        {
            if(registros.Exists(x => x.contato.Numero == contatoInformado.Numero) == true)
                return true;

            return false;
            
        }
    }
}
