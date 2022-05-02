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
        public string cargo;
        public override string ToString()
        {
            return $"Numero: {Numero} | Nome: {nome} | Cargo: {cargo} | Telefone: {telefone} | Empresa: {empresa} | Email: {email}";
        }

        public override string Validar()
        {
            string mensagem = "";
            ValidacaoCampo validacaoCampo = new ValidacaoCampo();

            if (nome == "" || telefone == "" || email == "")
                return "Campos NOME, EMAIL, TELEFONE são obrigatórios";

            if (!validacaoCampo.ValidarEmail(email))
                mensagem = "EMAIL_INVALIDO";

            if (!validacaoCampo.ValidaTelefone(telefone))
                mensagem += "\nTELEFONE_INVALIDO";

            if (mensagem != "")
                return mensagem;

            return "REGISTRO_VALIDO";
        }

        public bool VerificaCamposIguais(Contato contato)
        {
            bool emailIgual = this.email.Equals(contato.email);
            bool nomeIgual = this.nome.Equals(contato.nome);
            bool telefoneIgual = this.telefone.Equals(contato.telefone);

            if (emailIgual || nomeIgual || telefoneIgual)
                return true;

            return false;
        }
    }
}
