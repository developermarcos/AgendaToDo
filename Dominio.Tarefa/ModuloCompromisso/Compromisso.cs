using Dominio.ToDo.Compartilhado;
using Dominio.ToDo.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public string local;
        public DateTime dataCompromisso;
        public TimeSpan horaInicio;
        public TimeSpan horaFim;
        public Contato contato;
        public override string ToString()
        {
            return $"Numero: {Numero}  |  Assunto: {assunto}  |  Local: {local}  |  Data: {DataCompromisso}  |  Período {HoraInicio} a {HoraFim}";
        }

        public string DataCompromisso
        {
            get { return dataCompromisso.ToString("dd/MM/yyyy"); }
        }

        public string HoraInicio
        {
            get { return horaInicio.ToString(@"hh\:mm"); }
        }

        public string HoraFim
        {
            get { return horaFim.ToString(@"hh\:mm"); }
        }
        
        public bool SetHorarios(string horarioInicio, string horarioFim)
        {
            if (TimeSpan.TryParse(horarioInicio, out TimeSpan inicio) == true && TimeSpan.TryParse(horarioFim, out TimeSpan fim) == true)
            {
                this.horaInicio = inicio;
                this.horaFim = fim;
                return true;
            }
            return false;
        }

        public override string Validar()
        {
            string mensagem = "";
            ValidacaoCampo validacaoCampo = new ValidacaoCampo();

            if (assunto == "" || local == "" || dataCompromisso.Equals(null))
                return "Campos ASSUNTO, LOCAL, DATA COMPROMISSO são obrigatórios";

            if (dataCompromisso < DateTime.Now)
                mensagem = "-DATA INFORMADA MENOR QUE DATA ATUAL";

            if (horaInicio > horaFim)
                mensagem += "\n-HORA DE INICIO NÃO PODE SER MAIOR QUE HORA DE FIM";

            if (mensagem != "")
                return mensagem;

            return "REGISTRO_VALIDO";
        }

        public bool ExisteConflitoCompromissos(Compromisso compromisso)
        {
            if (horaInicio > compromisso.horaInicio && horaInicio < compromisso.horaFim)
                return true;
            if (horaInicio > compromisso.horaInicio && horaFim < compromisso.horaFim)
                return true;

            return false;
        }
    }
}
