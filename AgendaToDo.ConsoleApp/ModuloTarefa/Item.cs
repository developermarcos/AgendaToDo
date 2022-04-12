using AgendaToDo.ConsoleApp.Compartilhado;
using System;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class Item
    {
        public int Id { get; set; }
        public string descricao;
        private decimal percentual;

        public Item() { }
        public Item(int id, string descricao, decimal percentual)
        {
            this.Id = id;
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
            return $"ID: {Id} | Descrição: {descricao} | Percentual: {percentual}";
        }
    }
}
