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
        
        public DateTime dataCriacao { get; }

        public DateTime dataTermino;

        public List<Item> itens;

        public Tarefa(Prioridade prioridade, string titulo, DateTime dataCriacao, DateTime dataTermino, List<Item> itens)
        {
            this.prioridade = prioridade;
            this.titulo = titulo;
            this.dataCriacao = dataCriacao;
            this.dataTermino = dataTermino;
            this.itens = itens;
        }

        public Tarefa(Prioridade prioridade, string titulo, DateTime dataFim, List<Item> itens)
        {
            this.prioridade=prioridade;
            this.titulo=titulo;
            this.dataTermino=dataFim;
            this.itens=itens;
        }

        public override string Validar()
        {
            return "REGISTRO_VALIDO";
        }

        public decimal ObterPercentual()
        {
            decimal total = itens.Sum(item => item.Percentual);
            return  total / itens.Count;
        }

        public override string ToString()
        {
            string mensagem = $"Numero: {numero} | Titulo: {titulo} | Criacao: {dataCriacao} | Termino: {dataTermino} | Percentual: {ObterPercentual()}";

            foreach(Item item in itens)
                mensagem += "\n"+item.ToString();

            return mensagem;
        }

    }
}
