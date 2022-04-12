using AgendaToDo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public Prioridade prioridade { get; set; }
        public string titulo { get; set; }
        
        private DateTime dataCriacao { get; }

        public DateTime dataDevolucao;

        private decimal percentual;

        List<Item> itens;

        public Tarefa(Prioridade prioridade, string titulo, DateTime dataCriacao, DateTime dataDevolucao)
        {
            this.prioridade = prioridade;
            this.titulo = titulo;
            this.dataCriacao = dataCriacao;
            this.dataDevolucao = dataDevolucao;
            this.itens = new List<Item>();
        }

        public override string Validar()
        {
            throw new System.NotImplementedException();
        }

        public decimal ObterPercentual()
        {
            decimal total = itens.Sum(item => item.Percentual);
            percentual = total / itens.Count;
            return percentual;
        }

    }
}
