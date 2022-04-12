using AgendaToDo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace AgendaToDo.ConsoleApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> CompromissoSemana()
        {
            List<Compromisso> compromissosSemana = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if(compromisso.CompromissoSemana())
                    compromissosSemana.Add(compromisso);
            }

            return compromissosSemana;
        }
        public List<Compromisso> CompromissoDia()
        {
            List<Compromisso> compromissosDia = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.CompromissoDia())
                    compromissosDia.Add(compromisso);
            }

            return compromissosDia;
        }

        public List<Compromisso> CompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.CompromissoPassado())
                    compromissosPassados.Add(compromisso);
            }

            return compromissosPassados;
        }

        public List<Compromisso> CompromissosFuturos(DateTime inicio, DateTime fim)
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.ComprimissoFuturo(inicio, fim))
                    compromissosFuturos.Add(compromisso);
            }

            return compromissosFuturos;
        }
    }
}
