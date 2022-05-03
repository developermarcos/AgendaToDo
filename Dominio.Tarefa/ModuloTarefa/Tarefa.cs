using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.ToDo.Compartilhado;

namespace Dominio.ToDo.ModuloTarefa
{
    public enum Prioridade
    {
        Baixa = 1, Media = 2, Alta = 3
    }
    [Serializable]
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }

        public Prioridade prioridade { get; set; }
        public List<ItemTarefa> Itens { get { return itens; } }

        private List<ItemTarefa> itens = new List<ItemTarefa>();

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero}, Título: {Titulo}, Prioridade {prioridade}, Percentual: {percentual}, " +
                    $"Concluída: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número: {Numero}, Título: {Titulo}, Prioridade {prioridade}, Percentual: {percentual}";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }

        public override string Validar()
        {
            string validarRegistro = "";
            if (Titulo == "")
                validarRegistro += "\nNOME NÃO PODE SER VAZIO";

            if(validarRegistro == "")
                validarRegistro = "REGISTRO_VALIDO";

            prioridade = prioridade != 0 ? prioridade : Prioridade.Baixa;

            return validarRegistro;

        }
    }
}