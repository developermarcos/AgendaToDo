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
        private DateTime dataCompromisso;
        private DateTime horaInicio1;
        private DateTime horaFim;

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

        public bool CompromissoSemana()
        {
            return false;
        }

        public bool CompromissoDia()
        {
            return false;
        }
        public bool CompromissoPassado()
        {
            return false;
        }

        public bool ComprimissoFuturo(DateTime inicio, DateTime fim)
        {
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
