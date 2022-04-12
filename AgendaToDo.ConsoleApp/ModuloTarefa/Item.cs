﻿using AgendaToDo.ConsoleApp.Compartilhado;
using System;

namespace AgendaToDo.ConsoleApp.ModuloTarefa
{
    public class Item
    {
        public int Id { get; set; }
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

        public override string ToString()
        {
            return $"ID: {Id} | Descrição: {descricao} | Percentual: {percentual}";
        }
    }
}
