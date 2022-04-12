using AgendaToDo.ConsoleApp.Compartilhado;
using AgendaToDo.ConsoleApp.ModuloContato;
using System;

namespace AgendaToDo.ConsoleApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public string local;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;
        public Contato contato;
        
        public Compromisso(string assunto, string local, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino, Contato contato)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contato = contato;
        }

        public override string Validar()
        {
            return "REGISTRO_VALIDO";
        }

        public bool CompromissoSemana(DateTime dataFiltro)
        {
            DateTime dataInicio = dataFiltro;
            DateTime datafim = dataFiltro.AddDays(7);

            if (dataInicio <= data && data <= datafim)
                return true;

            return false;
        }

        public bool CompromissoDia(DateTime dataFiltro)
        {
            if (data.Date == dataFiltro.Date)
                return true;

            return false;
        }
        public bool CompromissoPassado()
        {
            if (data < DateTime.Now)
                return true;

            return false;
        }

        public bool ComprimissoFuturo(DateTime inicio, DateTime fim)
        {
            if (inicio <= data && data <= fim)
                return true;

            return false;
        }

        public override string ToString()
        {
            string mensagem = $"ID: {this.numero} | Assunto: {this.assunto} | Local: {this.local} | Data: {this.data.ToString("dd/MM/yyyy")} | Inicio: {this.horaInicio.ToString(@"hh\:mm")} | Termino: {this.horaTermino.ToString(@"hh\:mm")}\n";
            mensagem += $"Nome: {this.contato.nome} | Telefone: {this.contato.telefone} | Empresa: {this.contato.empresa}";
            return mensagem;
        }
    }
}
