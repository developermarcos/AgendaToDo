using AgendaToDo.ConsoleApp.Compartilhado;
using System;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class Item : EntidadeBase
    {
        public string descricao;
        private decimal percentual;
        public decimal Percentual
        {
            get { return percentual; }
            set 
            { 
                percentual = decimal.Round(percentual, 2, MidpointRounding.ToEven);
            }
        }
        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
