using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.ToDo.Compartilhado
{
    internal class ValidacaoCampo
    {
        public bool ValidaTelefone(string telefone)
        {
            Regex Rgx = new Regex(@"^\(\d{2}\)\d{5}-\d{4}$"); //formato (XX)XXXXX-XXXX

            if (!Rgx.IsMatch(telefone))
                return false;

            else
                return true;
        }

        public bool ValidarEmail(string email)
        {
            bool ValidEmail = false;
            int indexArr = email.IndexOf("@");

            if (indexArr > 0)
            {
                int indexDot = email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }
    }
}
