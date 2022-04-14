using AgendaToDo.ConsoleApp.Compartilhado;
using System;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class Item
    {
        public string descricao;
        private decimal percentual;

        public Item() { }
        public Item(string descricao, decimal percentual)
        {
            this.descricao = descricao;
            this.percentual = percentual;
        }
        public decimal Percentual
        {
            get { return percentual; }
            set { percentual = value; }
        }

        public override string ToString()
        {
            return $"Descrição: {descricao} | Percentual: {percentual}";
        }
    }
}
