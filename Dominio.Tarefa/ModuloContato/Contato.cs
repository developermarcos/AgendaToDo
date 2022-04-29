using Dominio.ToDo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ToDo.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string nome;
        public string email;
        public string empresa;
        public string telefone;
        public override string ToString()
        {
            return $"Numero: {Numero} | Nome: {nome} | Telefone: {telefone} | Empresa: {empresa} | Email: {email}";
        }

        public override string Validar()
        {
            string mensagem = "";
            ValidacaoCampo validacaoCampo = new ValidacaoCampo();

            if (!validacaoCampo.ValidarEmail(email))
                mensagem = "EMAIL_INVALIDO";

            if (!validacaoCampo.ValidaTelefone(telefone))
                mensagem += "\nTELEFONE_INVALIDO";

            if (mensagem != "")
                return mensagem;

            return "REGISTRO_VALIDO";
        }
    }
}
