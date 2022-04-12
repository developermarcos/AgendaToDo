using AgendaToDo.ConsoleApp.Compartilhado;
using System.ComponentModel.DataAnnotations;

namespace AgendaToDo.ConsoleApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string nome;
        public string email;
        public string telefone;
        public string empresa;
        public string cargo;
        
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            this.nome=nome;
            this.email=email;
            this.telefone=telefone;
            this.empresa=empresa;
            this.cargo=cargo;
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

        public override string ToString()
        {
            return $"ID: {this.numero} | Nome : {this.nome} | Email : {this.email} | Telefone : {this.telefone} | Empresa : {this.empresa} | Cargo : {this.cargo}";
        }
    }
}
